using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class ClearList
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

            Console.WriteLine("Elements in array list");
            foreach (var item in arrayList)
            {

                Console.WriteLine($"{item}");
            }
            int totalItems = arrayList.Count;

            Console.WriteLine(string.Format($"total items:{totalItems}, capacity: {arrayList.Capacity}"));

            arrayList.Clear();

            totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"total items:{totalItems}, capacity: {arrayList.Capacity}"));
            Console.ReadLine();
        }
    }
}
