using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class InsertCollection
    {
        static void Main(string[] args)
        {
            ArrayList array1 = new ArrayList()
            {
                "Govada",
                "amarthuluru",
                "peddapudi",
                "Kuchipudi",
                "Peddaravuru",
                "tenali"
            };

            Console.WriteLine("Array lsit Items");
            for (int i = 0; i < array1.Count; i++)
            {
                Console.WriteLine($"{array1[i]}");
            }

            ArrayList array2 = new ArrayList()
            {
                "Nandivelugu",
                "dugrila"
            };

            array1.InsertRange(6, array2);

            Console.WriteLine("\n\nArray list of Elements for New insert");
            foreach(var item in array1)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadLine();
        }
    }
}
