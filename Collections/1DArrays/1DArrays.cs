using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections._1DArrays
{
    public class _1DArrays
    {
        static void Main()
        {
            int[] Numbers = {10, 20,  30};

            Console.WriteLine("Accessing the Array Elements seperatly");
            Console.WriteLine($"Number[0] = {Numbers[0]}");
            Console.WriteLine($"Number[1] = {Numbers[1]}");
            Console.WriteLine($"Number[2] = {Numbers[2]}");

            Console.WriteLine("Accessing the Array Elements by using foreach Loop");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
            }
            Console.WriteLine("Accessign the Array Elements by using foreach loop");

            foreach (int Number in Numbers)
            {
                Console.WriteLine($"{Number}");
            }
        }

    }
}
