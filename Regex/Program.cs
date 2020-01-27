using System;
using System.Text.RegularExpressions;

namespace Regexs
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine();

                string pattern = @"^[A-Z][A-z]{1,30}$";

                if (Regex.IsMatch(name, pattern))
                {
                    Console.WriteLine("Name valid");
                }
                else
                {
                    Console.WriteLine("Name invalid");
                }
                Console.WriteLine();

                Console.Write("Please enter your email address: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                string emailPattern = @"^([a-z]{5,30})@([a-z]{5,10})((\.[a-z]{2,3}))$";

                if (Regex.IsMatch(email, emailPattern))
                {
                    Console.WriteLine("Email valid");
                }
                else
                {
                    Console.WriteLine("Email invalid");
                }
                Console.WriteLine();

                Console.Write("Please enter your phone number: ");
                string phone = Console.ReadLine();
                Console.WriteLine();
         
                string phonePattern = @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}";

                if (Regex.IsMatch(phone, phonePattern))
                {
                    Console.WriteLine("Phone number valid");
                }
                else
                {
                    Console.WriteLine("Phone number invalid");
                }

                 Console.WriteLine();

                Console.Write("Please enter a date: ");
                string date = Console.ReadLine();
                Console.WriteLine();

                string datePattern = @"^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$";

                 if (Regex.IsMatch(date, datePattern))
                 {
                Console.WriteLine("The date is valid");
                 }
                 else
                 {
                Console.WriteLine("The date is invalid");
                 }

                Console.WriteLine();
        }
      
    }
}
