using System.Linq;
using CMSolution.Question2;
using Xunit;

namespace CMSolutionTests.Question2
{
    public class CmPositiveDivisorsTests
    {
        private readonly CmPositiveDivisors _fakeCmPositiveDivisors;

        public CmPositiveDivisorsTests()
        {
            _fakeCmPositiveDivisors = new CmPositiveDivisors();    
        }

        [Fact]
        public void GetPositiveDivisors_InputIsNegative_ReturnsNull()
        {
            var mockDivisors = _fakeCmPositiveDivisors.GetPositiveDivisors(-60);

            Assert.Null(mockDivisors);
        }

        [Fact]
        public void GetPositiveDivisors_InputIsZero_ReturnsEmptyEnumerable()
        {
            var mockDivisors = _fakeCmPositiveDivisors.GetPositiveDivisors(0).ToList();

            Assert.Empty(mockDivisors);
        }

        [Fact]
        public void GetPositiveDivisors_InputIsAnIntegerGreaterThanZero_ReturnsEnumerationWithPositiveDivisors()
        {
            var mockDivisors = _fakeCmPositiveDivisors.GetPositiveDivisors(60).ToList();

            Assert.Equal(12, mockDivisors.Count);
            Assert.Collection(mockDivisors, value =>
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
                    Assert.Equal(10, value);
                },
                value =>
                {
                    Assert.Equal(12, value);
                },
                value =>
                {
                    Assert.Equal(15, value);
                },
                value =>
                {
                    Assert.Equal(20, value);
                },
                value =>
                {
                    Assert.Equal(30, value);
                },
                value =>
                {
                    Assert.Equal(60, value);
                });
        }
    }
}
