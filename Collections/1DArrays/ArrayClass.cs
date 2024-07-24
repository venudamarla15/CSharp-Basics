using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections._1DArrays
{
    public class ArrayClass
    {
        static void Main()
        {
            int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };

            Console.WriteLine("Original Array");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i] + " ");
            }

            Console.WriteLine();

            Array.Sort(Numbers);

            Console.WriteLine("\nArray Elements After sorting");

            foreach(int i in Numbers)
            {
                Console.WriteLine( i + "");
            }

            Array.Reverse(Numbers);

            Console.WriteLine("\nArray Elements in the Reverse Order :");
            foreach (int i in Numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int[] NewNumber = new int[10];

            Array.Copy(Numbers,NewNumber,6);

            Console.WriteLine("\nNew Array Elements:");

            foreach(int i in NewNumber)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine($"New Array length using lenth property: {NewNumber.Length}");
            Console.WriteLine($"New Arraylength using getLength:{NewNumber.GetLength(0)}");
            Console.ReadLine();
        }
    }
}
