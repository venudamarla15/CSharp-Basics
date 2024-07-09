    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Third_example
    {
        static void Main()
        {
            Console.WriteLine("Enter the string:");

            string name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);


            string reverse = new string(nameArray);

            if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name} : is a palindrome");
            }
            else
            {
                Console.WriteLine($"{name}: is not a palindrome");

            }
            Console.ReadLine();
        }
    }
}