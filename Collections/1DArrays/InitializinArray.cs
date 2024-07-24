using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class InitializinArray
    {
        static void Main()
        {
            int[] Numbers = new int[4];

            Console.WriteLine("Accessing the elements before Initializing");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");

            }

            Numbers[0] = 10;
            Numbers[1] = 20;
            Numbers[2] = 30;
            Numbers[3] = 40;

            Console.WriteLine("\nAccessing the Array Elements After Initialization");

            for (int i = 0; i < Numbers.Length; i++) 
            {
                Console.WriteLine($"Number[{i}] = {Numbers[i]}");
            }
            Console.ReadLine(); 
        }
    }
}
