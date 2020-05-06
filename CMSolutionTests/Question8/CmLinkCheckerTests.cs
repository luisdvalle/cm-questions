using System.Threading.Tasks;
using CMSolution.Question8;
using Xunit;

namespace CMSolutionTests.Question8
{
    public class CmLinkCheckerTests
    {
        [Fact]
        public async Task JustATet()
        {
            var cmLinkChecker = new CmLinkChecker("http://google.com");
            await cmLinkChecker.ReleaseTheKraken();
        }
    }
}
