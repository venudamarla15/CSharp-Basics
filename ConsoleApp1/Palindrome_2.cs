using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindrome_2
    {
        static void Main()
        {
            Console.WriteLine("Ener string:");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            foreach(char c in name)
            {
                reverse = c + name;
            }
            if(name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name}: is a palindrome");
            }
            else
            {
                Console.WriteLine($"{name}:is not a palindrome");
            }

            Console.ReadLine();
        }
    }
}
