using System.Collections.Generic;

namespace CMSolution.Question2
{
    public class CmPositiveDivisors
    {
        public IEnumerable<int> GetPositiveDivisors(int input)
        {
            var divisors = new List<int>();

            if (input < 0)
            {
                return null;
            }

            for (var i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    divisors.Add(i);
                }    
            }

            return divisors;
        }
    }
}
