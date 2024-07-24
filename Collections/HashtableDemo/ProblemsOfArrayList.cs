using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collections.HashtableDemo
{
    public class ProblemsOfArrayList
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(101);
            arrayList.Add("Venu");
            arrayList.Add("Manager");
            arrayList.Add(3500);
            arrayList.Add("Texas");
            arrayList.Add("IT");
            arrayList.Add("vd123@g.com");

            Console.WriteLine("Location:" + arrayList[4]);

            Console.ReadLine();
        }
    }
}
