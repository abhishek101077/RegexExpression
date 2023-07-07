using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regix_expression
{
     public class UC5
    {
        public void solution()
        {
            Regex regex = new Regex(@"([^\s]+(\.(?i)(jpe?g|png|gif|bmp))$)");

            Console.WriteLine("Enter filename with image file extension : ");
            string filename = Console.ReadLine();
            if (regex.IsMatch(filename))
            {
                Console.WriteLine("Valid file name");
            }
            else
            {
                Console.WriteLine("Invalid file name");
            }
        }
    }
}
