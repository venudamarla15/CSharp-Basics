using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.SortedListDemo
{
    public class CreateSL
    {
        static void Main()
        {
            SortedList sl = new SortedList();

            sl.Add(1, "Venu");
            sl.Add(2, 3.4f);
            sl.Add(3, true);
            sl.Add(4, "sai");

            Console.WriteLine("Accessing SortedList using For loop");
            for(int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine($"Key:{sl.GetKey(i)}, value:{sl.GetByIndex(i)}");
            }
            Console.ReadKey();
        }
    }
}
