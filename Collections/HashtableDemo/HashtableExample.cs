using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections.HashtableDemo
{
    public class HashtableExample
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("Id", 101);
            hashtable.Add("Name", "Venu");
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Texas");
            hashtable.Add("Email", "123vd@g.com");

            Console.WriteLine("Printing HashTable values by using foreach Loop");

            foreach (object obj in hashtable)
            {
               // Console.WriteLine(obj);
                Console.WriteLine(obj + " : " + hashtable[obj]);
            }

            Console.WriteLine("\nPrinting Hashtable using Keys");
             Console.WriteLine("Email Id:" + hashtable["Email"]);

            Console.ReadLine();
        }
    }
}
