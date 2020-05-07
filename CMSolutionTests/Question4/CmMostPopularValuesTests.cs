using System.Linq;
using CMSolution.Question4;
using Xunit;

namespace CMSolutionTests.Question4
{
    public class CmMostPopularValuesTests
    {
        private readonly CmMostPopularValues _fakeCmMostPopularValues;

        public CmMostPopularValuesTests()
        {
            _fakeCmMostPopularValues = new CmMostPopularValues();    
        }

        [Fact]
        public void GetMostPopularValues_OneValueIsTheMostPopularInTheInputList_ReturnsThatValue()
        {
            var mockResultsList = _fakeCmMostPopularValues.GetMostPopularValues(new[] { 1, 2, 3, 4, 5, 1, 6, 7 }).ToList();

            Assert.Single(mockResultsList);
            Assert.Collection(mockResultsList, value => { Assert.Equal(1, value); });
        }

        [Fact]
        public void GetMostPopularValues_TwoValuesAreTheMostPopularInTheInputList_ReturnsTwoValues()
        {
            var mockResultsList = _fakeCmMostPopularValues.GetMostPopularValues(new[] {5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4}).ToList();

            Assert.Equal(2, mockResultsList.Count);
            Assert.Collection(mockResultsList, value =>
                {
                    Assert.Equal(5, value);
                },
                value =>
                {
                    Assert.Equal(4, value);
                });
        }

        [Fact]
        public void GetMostPopularValues_AllValuesInTheInputListHaveTheSamePopularity_ReturnsAllValues()
        {
            var mockResultsList = _fakeCmMostPopularValues.GetMostPopularValues(new[] { 1, 2, 3, 4, 5, 6, 7 }).ToList();

            Assert.Equal(7, mockResultsList.Count);
            Assert.Collection(mockResultsList, value =>
                {
                    Assert.Equal(1, value);
                },
                value =>
                {
                    Assert.Equal(2, value);
                },
                value =>
                {
                    Assert.Equal(3, value);
                },
                value =>
                {
                    Assert.Equal(4, value);
                },
                value =>
                {
                    Assert.Equal(5, value);
                },
                value =>
                {
                    Assert.Equal(6, value);
                },
                value =>
                {
                    Assert.Equal(7, value);
                });
        }
    }
}
