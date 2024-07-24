using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class ArrayDemo
    {
        static void Main()
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101);
            arrayList1.Add("James");
            arrayList1.Add(true);
            arrayList1.Add(4.5);

           foreach(var item in arrayList1)
            {
                Console.WriteLine($"{item}");
            }

            int firstElement = (int)arrayList1[0];
            string secondELement = (string)arrayList1[1];

            Console.WriteLine($"First Element: {firstElement}, SecondElement:{secondELement}");

            var firstItem = arrayList1[0];
            var secondItem = arrayList1[1];

            Console.WriteLine($"First Item:{firstElement}, secondItem:{secondELement}");

            arrayList1[0] = "smith";
            arrayList1[1] = 102;

            foreach(var item in arrayList1)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadLine();
        }
       
    }
}
