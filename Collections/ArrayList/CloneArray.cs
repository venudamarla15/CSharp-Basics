using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class CloneArray
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
            
            ArrayList cloneArrayList = (ArrayList) arrayList.Clone();

            Console.WriteLine("\n\nClone Array List");

            foreach (var item in cloneArrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
