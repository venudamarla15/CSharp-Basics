using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.SortedListDemo
{
    public class AddandRemoveSL
    {
        static void Main()
        {
            SortedList sl = new SortedList();

            sl.Add(1, "Venu");
            sl.Add(2, "saranya");
            sl.Add(3, "Dallas");

            Console.WriteLine("elements in soreted list");
            Console.WriteLine($"\n elemetns: {sl.Count}");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"key:{item.Key}, value:{item.Value}");

            }

            sl.Remove(3);
            Console.WriteLine("\nElements after Removing");
            Console.WriteLine($"\n elemetns: {sl.Count}");
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine($"Keys: {sl.GetKey(i)}, value:{sl.GetByIndex(i)}");
            }

            sl.Clear();
            Console.WriteLine($"\n elemetns: {sl.Count}");
            Console.ReadLine();
        }
    }
}
