using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class CopyArray2
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "HongKong",
            };

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            object[] array = new object[arrayList.Count];

            arrayList.CopyTo(array);

            Console.WriteLine("\n\n Copy Array Elements ");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            object[] array1 = new object[arrayList.Count];
            arrayList.CopyTo(array1, 1);

            Console.WriteLine("\n\n Array list after copy parameter");
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
