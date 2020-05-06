using CMSolution.Question3;
using Xunit;

namespace CMSolutionTests.Question3
{
    public class CmAreaUtilityTests
    {
        [Fact]
        public void GetArea_TriangleIsInvalid_ThrowsInvalidTriangleException()
        {
            Assert.Throws<InvalidTriangleException>(() => CmAreaUtility.GetArea(20, 10, 10));
        }

        [Fact]
        public void GetArea_TriangleHasNegativeValues_ThrowsInvalidTriangleException()
        {
            Assert.Throws<InvalidTriangleException>(() => CmAreaUtility.GetArea(-10, 10, 10));
        }

        [Theory]
        [InlineData(10, 10, 10, 43.301)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(10, 10, 5, 24.206)]
        public void GetArea_TriangleIsValid_ReturnsArea(int side1, int side2, int side3, double result)
        {
            var mockArea = CmAreaUtility.GetArea(side1, side2, side3);

            Assert.Equal(result, mockArea);
        }
    }
}
