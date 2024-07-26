using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.HashListDemo
{
    public class IntersectExample
    {
        static void Main()
        {
            HashSet<string> list = new HashSet<string>
            {
                "Ind",
                "USA",
                "UK",
                "NZ"
            };
            Console.WriteLine("List1 Items:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            HashSet<string> list1 = new HashSet<string>();
            //Adding Elements to HashSet using Add Method
            list1.Add("Ind");
            list1.Add("USA");
            list1.Add("SA");
            list1.Add("SL");
            list1.Add("ZIM");

            Console.WriteLine("\nList1 ELements:");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            //list.IntersectWith(list1);

            //Console.WriteLine("\n After Intesections");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("\n exception with Elements");

            list.ExceptWith(list1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
