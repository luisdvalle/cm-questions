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
            //var cmLinkChecker = new CmLinkChecker("https://news.microsoft.com");
            //var cmLinkChecker = new CmLinkChecker("https://www.campaignmonitor.com/");
            var cmLinkChecker = new CmLinkChecker("https://www.w3schools.com");

            await cmLinkChecker.ReleaseTheKraken();
        }
    }
}
