using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regix_expression
{
    public class practice
    {
        public static void valid_Last_name()
        {
            Console.WriteLine("Enter last name");
            string data = Console.ReadLine();
            string namepattern = "^[A-Z]{1}[A-Za-z]{,3}$";
            Regex regexobj = new Regex(namepattern);
            if (regexobj.IsMatch(data))
            {
                Console.WriteLine("name is correct");
            }
            else
            {
                Console.WriteLine("name is incorrect");
            }
        }

            public static void valid_first_name()

            {
                Console.WriteLine("Enter last name");
                string data = Console.ReadLine();

                string namepattern = "^[A-Z]{1}[A-Za-z]{3,}$";

                Regex regexobj = new Regex(namepattern);
                if (regexobj.IsMatch(data))
                {
                    Console.WriteLine("name is correct");
                }
                else
                {
                    Console.WriteLine("name is incorrect");
                }
            }
        }
    }

