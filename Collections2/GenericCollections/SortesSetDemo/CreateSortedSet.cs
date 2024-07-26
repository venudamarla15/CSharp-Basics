using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.SortesSetDemo
{
    public class CreateSortedSet
    {
        static void Main()
        {
            SortedSet<int> s = new SortedSet<int>();
            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            s.Add(1);

            Console.WriteLine("SortedSet list :}" + s);

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
