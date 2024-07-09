using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class palindrome_otherimpl
    {

        public static void chkPalindrome(string str)
        {
            bool flag = false;
            for(int i =0, j = str.Length-1; i< str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else 
                    flag = true;
                if(flag)
                {
                    Console.WriteLine("is palandrom");

                }
                else
                {
                    Console.WriteLine("is not a palandrom");
                }
            }

           
        }
        static void Main()
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            chkPalindrome(input);
        }
    }
}
