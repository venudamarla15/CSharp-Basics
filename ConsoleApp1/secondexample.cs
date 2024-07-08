using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class secondexample
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for(int i= name.Length-1; i >= 0; i--)
            {
                reverse += name[i];
            }
            if(name == reverse)
            {
                Console.WriteLine($"{name}: is a palindrome");
            }
            else
            {
                Console.WriteLine($"{name}: is not a palindrome");
            }
            Console.ReadLine();

        }

    }
}
