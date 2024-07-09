using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReverseString_another_approach
    {
        public static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--) 
            {
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            string reverse = new string(charArray);
            Console.WriteLine(reverse);

        }

        static void Main()
        {
            Console.WriteLine("Enter the string ");
            string input = Console.ReadLine();  
            ReverseString(input);
        }

    }
}
