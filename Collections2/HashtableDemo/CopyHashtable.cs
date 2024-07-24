using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.HashtableDemo
{
    public class CopyHashtable
    {
        static void  Main()
        {
            Hashtable ht = new Hashtable
            {

                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };

            Console.WriteLine("HashTable Elements");
            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");

            }
            DictionaryEntry[] myArray = new DictionaryEntry [ht.Count];
            ht.CopyTo (myArray, 0);
            Console.WriteLine("\nHashtable Copy Array Elements:");
            foreach (DictionaryEntry item in myArray)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Object[] myObjArrayKey = new Object[ht.Count];
            Object[] myObjArrayValue = new Object[ht.Count];
            Console.WriteLine("\n Copy method to key");
            ht.Keys.CopyTo(myObjArrayKey, 0);
            foreach(var item in myObjArrayKey)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("\nCopyTo Method to Copy Values:");
            ht.Values.CopyTo(myObjArrayValue, 0);
            foreach (var key in myObjArrayValue)
            {
                Console.WriteLine($"{key} ");
            }
            Console.ReadKey();
        }
    }
}
