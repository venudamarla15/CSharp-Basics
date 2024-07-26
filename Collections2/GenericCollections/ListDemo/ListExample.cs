using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.ListDemo
{
    public class ListExample
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
