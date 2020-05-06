using System.Collections.Generic;
using System.Linq;

namespace CMSolution.Question4
{
    public class CmMostPopularValues
    {
        public IEnumerable<int> GetMostPopularValues(int[] values)
        {
            var resultList = new List<int>();
            var dictionaryCounts = new Dictionary<int, int>();

            foreach (var value in values)
            {
                if (!dictionaryCounts.ContainsKey(value))
                {
                    dictionaryCounts[value] = 1;
                }
                else
                {
                    dictionaryCounts[value] = ++dictionaryCounts[value];
                }
            }

            var maximumValue = dictionaryCounts.Values.Max();

            foreach (var (key, value) in dictionaryCounts)
            {
                if (value == maximumValue)
                {
                    resultList.Add(key);
                }
            }

            return resultList;
        }
    }
}
