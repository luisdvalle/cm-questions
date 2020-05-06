using System.Linq;
using CMSolution.Question4;
using Xunit;

namespace CMSolutionTests.Question4
{
    public class CmMostPopularValuesTests
    {
        [Fact]
        public void JustATest()
        {
            var cmMostPopularValues = new CmMostPopularValues();
            var resultsList = cmMostPopularValues.GetMostPopularValues(new[] {5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4}).ToList();

            Assert.Equal(2, resultsList.Count);
            Assert.Collection(resultsList, value =>
                {
                    Assert.Equal(5, value);
                },
                value =>
                {
                    Assert.Equal(4, value);
                });
        }
    }
}
