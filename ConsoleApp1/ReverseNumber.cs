using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            int remainder, reverse = 0;
            int temp = number;

            while (number > 0)
            {
                remainder = number % 10;

                reverse = (reverse*10) + remainder;

                number = number / 10;
            }

            Console.WriteLine("reverse number: "+ reverse);

            Console.WriteLine($"{number}: given Number");

            // check if the number is pallindrom 

            if (temp == reverse)
            {
                Console.WriteLine($"{temp} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{temp}: is not a palindrome");
            }

            Console.ReadLine();

        }
    }
}
