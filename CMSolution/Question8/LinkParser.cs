using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CMSolution.Question8
{
    public class LinkParser
    {
        private readonly string _linkTagPattern = "(?<=href=\\\")[^\\\"]*";

        public IEnumerable<string> GetUrlsFromTags(string myString)
        {
            var matches = Regex.Matches(myString, _linkTagPattern);
            return matches.Select(m => m.ToString());
        }
    }
}
