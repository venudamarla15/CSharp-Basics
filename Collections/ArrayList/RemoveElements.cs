using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class RemoveElements
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal",
                    "HongKong",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "HongKong",
            };

            Console.WriteLine("Array List Elemetns");

            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }

            arrayList.Remove("Japan");

            Console.WriteLine("\n\n Array elements after removing first occurance of Japan");

            foreach(var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }

            arrayList.RemoveAt(0);

            Console.WriteLine("\n\n Array list after removign with at");
            foreach( var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }

            arrayList.RemoveRange(2, 2);
            Console.WriteLine("\n\n Array list after removign with Range");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }
            
            Console.ReadLine();
        }
    }
}
