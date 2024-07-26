using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.ListDemo
{
    public class CreateList
    {
        static void Main()
        {
            List<string> list = new List<string>();

            list.Add("India");
            list.Add("UsA");

            List<string> list2 = new List<string>()
            {
                "China",
                "Japan",
                "pakistan",
                "India"

            };

           


            list.InsertRange(1, list2) ;
            
            foreach (var item in list)

            {
                Console.WriteLine($"List of Countries: {item}");
            
            }

            if(list.Contains("China"))
            {
                Console.WriteLine("\n Country is available");
            }
            else
            {
                Console.WriteLine("\n Not Available");
            }

            list.Remove("India");
            Console.WriteLine("\n List of countires after Remove");
            foreach (var i in list)

            {
                Console.WriteLine(i);

            }
            list.RemoveRange(2, 1);
            Console.WriteLine("\n List of countires after RemoveRange");
            foreach (var i in list)

            {
                Console.WriteLine(i);

            }

            List<string> newList = new List<string>(list);

            Console.WriteLine("Copied New List");
            foreach (var i in list2)

            {
                Console.WriteLine(i);

            }

            //Console.WriteLine("\n Accessign by usign index:");
            //Console.WriteLine($"FirstCountry: {list[0]}");
            //Console.WriteLine($"FirstCountry: {list[1]}");
            //Console.WriteLine($"FirstCountry: {list[2]}");
            //Console.WriteLine($"FirstCountry: {list[3]}");
        }
    }
}
