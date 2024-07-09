using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reversestring
    {
        static void Main()
        {
            #region 
            //forloop syntax

            //Console.WriteLine("Enter string:");

            //string Name = Console.ReadLine();

            //string reverse = string.Empty;

            //for (int i = Name.Length - 1; i >= 0; i--)
            //{
            //    reverse += Name[i];
            //}
            //Console.WriteLine(reverse);
            //Console.ReadLine();
            #endregion

            #region
            // foreach loop 
            //Console.WriteLine("Enter string");
            //string name = Console.ReadLine();
            //string Reverse = string.Empty;
            //foreach(var c in name)
            //{
            //    Reverse = c + Reverse;

            //}
            //Console.WriteLine(Reverse);
            //Console.ReadLine();
            #endregion

            #region
            // array.reverse method 
            Console.WriteLine("Enter string:");
             string name1 = Console.ReadLine();
            char[] nameArray = name1.ToCharArray();
            Array.Reverse(nameArray);   
            string reverse = new string(nameArray);

            Console.WriteLine(reverse);
            Console.ReadLine();
            #endregion
        }
    }
}
