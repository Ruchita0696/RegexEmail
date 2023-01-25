using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexEmail
{
    internal class RegexPattern
    {
        public static void Pattern(string pattern)
        {
            Regex email = new Regex(@"(abc)*[@](bridglabz)*[.](co)*[.]");
            bool matches = email.IsMatch(pattern);

            if (matches == true)
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Email");
            }
        }
    }
}
