using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.HashListDemo
{
    public class CreateHashSet
    {
        static void Main()
        {
            HashSet<string> list = new HashSet<string>();

            list.Add("India");
            list.Add("UK");
            list.Add("China");
            list.Add("USA");
            list.Add("Canada");

            Console.WriteLine($"Number of elemetns in Haslet:{list.Count}");

            foreach (var li in list)
            {
                Console.WriteLine(li);
            }

            Console.WriteLine($"\nis India exists:{list.Contains("India")}");

            HashSet<string> list1 = new HashSet<string>
            {
                "SouthAfrica",
                "SriLanka",
                "Malasisa",
                "India",
                "Canada"
            };

            foreach (var li in list1)
            {
                Console.WriteLine(li);
            }
            list.UnionWith(list1);
           // foreach (var li in list

            list.IntersectWith(list1);

            //list.Remove("China");
            Console.WriteLine($"\nNumber of elemetns in Haslet:{list.Count}");
            foreach (var li in list)
            {
                Console.WriteLine(li);
            }

            list.IntersectWith(list1);

            
            Console.WriteLine("\n Intersection example:");
            foreach (var li in list)
            {
                Console.WriteLine(li);
            }
            list.Remove("China");
            Console.WriteLine($"\nNumber of elemetns in Haslet:{list.Count}");
            foreach (var li in list)
            {
                Console.WriteLine(li);
            }

            list.RemoveWhere(x => x.Length > 2);
            Console.WriteLine($"\nNumber of elemetns in Haslet:{list.Count}");
            foreach (var li in list)
            {
                Console.WriteLine(li);
            }
        }
    }
}
