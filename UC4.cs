using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regix_expression
{
     public class UC4
    {

        public void solution()
        {
            {
                string pattern = "fox(es)?";
                string input = "@\"foxes are omnivorous mammals belonging to several genera of the family Canidae fox.\"";

                int count = CountPatternOccurrences(pattern, input);
                Console.WriteLine("There are {0} occurrences.", count);
            }

            static int CountPatternOccurrences(string pattern, string input)
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                return matches.Count;

            }
        }
    }
}
