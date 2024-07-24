using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.HashtableDemo
{
    public class Adding_Items_in_Hashtable
    {
        static void Main()
        {
            Hashtable citiesHashTable = new Hashtable()
            {
                { "UK","London, paris, Manchester" },
                {"India","Ap, Ts, Chennai, Hyd" },
                {"USA", "Texas, Chicago, New York" }

            };

            Console.WriteLine("Creatign HashTable using collection-Initializer");

            foreach (DictionaryEntry city in citiesHashTable)
            {
                Console.WriteLine($"Keys: {city.Key}, value:{city.Value}");
            }
            Console.ReadLine();
        }
    }
}
