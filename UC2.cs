using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regix_expression
{
      public class UC2
    {
        public void solution()
        {


            string input = "abbb";


            string pattern = "^a{1}b{2,3}$";


            Regex regex = new Regex(pattern);


            if (regex.IsMatch(input))
            {
                Console.WriteLine("String matched the pattern!");
            }
            else
            {
                Console.WriteLine("String did not match the pattern!");
            }
        }

    }
}
