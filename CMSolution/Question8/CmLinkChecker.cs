using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CMSolution.Question8
{
    public class CmLinkChecker
    {
        private static HttpClient _httpClient;
        private readonly LinkParser _linkParser;
        private readonly Uri _uri;
        private static ConcurrentDictionary<string, HttpStatusCode?> _dictionaryUrls;

        public CmLinkChecker(string url)
        {
            _httpClient = new HttpClient()
            {
                MaxResponseContentBufferSize = 1000000
            };
            _linkParser = new LinkParser();
            _dictionaryUrls = new ConcurrentDictionary<string, HttpStatusCode?>();
            _uri = new Uri(url);
        }

        public async Task ReleaseTheKraken()
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine($"\nProcessing all links in URL {_uri}...\n");

            await GetLinks();
            await HitLinks();
            PrintResults();
            Console.WriteLine($"Total Elapsed time: {sw.ElapsedMilliseconds}");
        }

        private async Task GetLinks()
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine($"Parsing all links from HTML...");
            var response = await _httpClient.GetAsync(_uri);
            var responseStr = await response.Content.ReadAsStringAsync();

            var links =_linkParser.GetUrlsFromTags(responseStr).ToList();

            foreach (var link in links)
            {
                _dictionaryUrls.TryAdd(link, null);
            }
            Console.WriteLine($"Parsing finished. ElapsedTime {sw.ElapsedMilliseconds} ms.\n");
        }

        private async Task HitLinks()
        {
            var requestsTasks = new List<Task<(string, HttpStatusCode)>>();

            foreach (var (url, result) in _dictionaryUrls)
            {
                requestsTasks.Add(ProcessRequest(url));
            }

            var results = await Task.WhenAll(requestsTasks);

            foreach (var (url, httpStatusCode) in results)
            {
                _dictionaryUrls[url] = httpStatusCode;
            }
        }

        private async Task<(string, HttpStatusCode)> ProcessRequest(string url)
        {
            var sw = new Stopwatch();
            sw.Start();

            try
            {
                var uri = new Uri(url);
                var response = await _httpClient.GetAsync(url);
                Console.WriteLine($"URL Processed | ElapsedTime: {sw.ElapsedMilliseconds} ms | " +
                                  $"Result: {response.StatusCode} | Url: {url}");
                return (url, response.StatusCode);
            }
            catch (UriFormatException)
            {
                Console.WriteLine($"URL Processed | ElapsedTime: {sw.ElapsedMilliseconds} ms | " +
                                  $"Result: {HttpStatusCode.UnprocessableEntity} | Url: {url}");
                return (url, HttpStatusCode.UnprocessableEntity);
            }
            catch (HttpRequestException)
            {
                Console.WriteLine($"URL Processed | ElapsedTime: {sw.ElapsedMilliseconds} ms | " +
                                  $"Result: {HttpStatusCode.GatewayTimeout} | Url: {url}");
                return (url, HttpStatusCode.GatewayTimeout);
            }
        }

        private void PrintResults()
        {
            Console.WriteLine($"\nTotal number of links processed: {_dictionaryUrls.Count}");
            Console.WriteLine($"Total number of successful links: {_dictionaryUrls.Count(kv => kv.Value == HttpStatusCode.OK)}");
            Console.WriteLine($"Total number of NOT successful links: {_dictionaryUrls.Count(kv => kv.Value != HttpStatusCode.OK)}");
        }
    }
}
