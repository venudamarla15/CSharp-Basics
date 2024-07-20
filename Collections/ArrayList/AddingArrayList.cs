using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ArrayListDemo
{
    public class AddingArrayList
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(101);
            arrayList.Add("James");
            arrayList.Add("james");
            arrayList.Add("");
            arrayList.Add(4.5);
            arrayList.Add(true);
            arrayList.Add(null);

            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }

            var arrayList2 = new ArrayList()

            {
                102, "Venu", false, 16.6
            };

            foreach(var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        

       

    }
}
