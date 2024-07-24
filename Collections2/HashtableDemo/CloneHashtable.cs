using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.HashtableDemo
{
    public class CloneHashtable
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using Add method
            hashtable.Add("EId", 1001);
            hashtable.Add("Name", "James");
            hashtable.Add("Job", "Developer");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("Dept", "IT");
            hashtable.Add("EmailID", "a@a.com");

            Console.WriteLine("HashTable Elements");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key:{entry.Key}, value: {entry.Value}");
            }

            Hashtable hashtable1 = (Hashtable)hashtable.Clone();

            Console.WriteLine("\n Cloned HashTable Elements");
            foreach (DictionaryEntry entry in hashtable1)
            {
                Console.WriteLine($"Key: {entry.Key}, Value:{entry.Value}");
            }

            Console.ReadLine();
        }
    }
}
