using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.HashtableDemo
{
    public class RemoveHastable
    {
        static void Main()
        {
            Hashtable ht = new Hashtable()
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };

            Console.WriteLine($"Hashtable Total Elements: {ht.Count}");

            ht.Remove("Salary");

            Console.WriteLine($"Hash table Element after Removed:{ht.Count}");

            if(ht.ContainsKey("City"))
            {
                ht.Remove("City");
            }
            else
            {
                Console.WriteLine($"Hashtable does not contain city Key");
            }

            ht.Clear();
            Console.WriteLine($"After clear hashtable:{ht.Count}");

            Console.ReadLine();
        }
    }
}
