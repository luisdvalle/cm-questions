using CMSolution.Question2;
using Xunit;

namespace CMSolutionTests.Question2
{
    public class CmPositiveDivisorsTests
    {
        private readonly CmPositiveDivisors _cmPositiveDivisors;

        public CmPositiveDivisorsTests()
        {
            _cmPositiveDivisors = new CmPositiveDivisors();    
        }

        [Fact]
        public void GetPositiveDivisors_InputIsAnIntegerGreaterThanZero_ReturnsEnumerationWithPositiveDivisors()
        {
            var mockDivisors = _cmPositiveDivisors.GetPositiveDivisors(-60);
        }
    }
}
