using System;
using System.Threading.Tasks;
using CMSolution.Question8;

namespace CMSolution
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();

            //var cmLinkChecker = new CmLinkChecker("http://google.com");
            var cmLinkChecker = new CmLinkChecker("https://news.microsoft.com/en-au/");
            await cmLinkChecker.ReleaseTheKraken();
        }
    }
}
