using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class InsertArraylsit
    {
        static void Main()
        {
            ArrayList array = new ArrayList()
            {
                101,
                "Venu",
                true,
                10.5
            };

            array.Insert(1, "Saranya");

            array.Insert(2, "Ravi");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
