using CMSolution.Question1;
using Xunit;

namespace CMSolutionTests.Question1
{
    public class CmStringTests
    {
        private readonly CmString _fakeCmString;

        public CmStringTests()
        {
            _fakeCmString = new CmString();
        }

        [Fact]
        public void IsNullOrEmpty_InputIsNull_ReturnsTrue()
        {
            var mockResult = _fakeCmString.IsNullOrEmpty(null);

            Assert.True(mockResult);
        }

        [Fact]
        public void IsNullOrEmpty_InputIsEmpty_ReturnsTrue()
        {
            var mockResult = _fakeCmString.IsNullOrEmpty("");

            Assert.True(mockResult);
        }

        [Theory]
        [InlineData("a")]
        [InlineData("null")]
        public void IsNullOrEmpty_InputIsNotNullNorEmpty_ReturnsFalse(string input)
        {
            var mockResult = _fakeCmString.IsNullOrEmpty(input);

            Assert.False(mockResult);
        }
    }
}
