using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.ListDemo
{
    public class SortingList
    {
        static void Main()
        {
            List<int> list = new List<int> { 7, 5, 34, 1, 20, 39, 21 };

            Console.WriteLine("List before sorting");

            foreach(var i in list)
            { 
                Console.WriteLine($"{i}");
            }

            list.Sort();
            Console.WriteLine("\n list after sorting");

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            list.Reverse();
            Console.WriteLine("\n List after Reverse");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            List<string> names = new List<string> { "Pranaya", "Anurag", "Sambit", "Hina", "Rakesh" };
            Console.WriteLine("\n\nNames Before Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Reverse();
            Console.WriteLine("\nNames in Descending Order");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
