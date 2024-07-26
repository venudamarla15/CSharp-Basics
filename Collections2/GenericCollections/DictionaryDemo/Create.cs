using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.DictionaryDemo
{
    public class Create
    {
        static void Main()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("UK", "London, Paris, manchester");
            dic.Add("Ind","Delhi, Chennai, Hyderabad");
            dic.Add("USA", "Texas, Chicago, New York");

            Console.WriteLine("Accessign the dictionary");

            foreach(KeyValuePair<string, string> kvp in dic)
            {
                Console.WriteLine($"key:{kvp.Key}, Value:{kvp.Value}");
            }

            Console.WriteLine("\nAccessing using For loop:");
            for(int i =0; i<dic.Count; i++)
            {
                string key = dic.Keys.ElementAt(i);
                string value = dic[key];

                Console.WriteLine($"Key:{key}, Value:{value}");
            }

            Console.WriteLine("\n accessing th Dictionary Elemetns using Keys");
            Console.WriteLine($"Key: UK, Value:{dic["UK"]}");
            Console.WriteLine($"Key: Ind Value:{dic["Ind"]}");

            Console.WriteLine("\n Checkign the key containd Method");

            Console.WriteLine("\n Checking Ind is available in Key:" + dic.ContainsKey("Ind"));

            Console.WriteLine("\n Checking the Value is availabe:");

            Console.WriteLine("\n Is Delhi value Exists:" + dic.ContainsValue("Delhi"));

            dic.Remove("Ind");

            Console.WriteLine("\nAfter Removing");

            for(int i =0; i<dic.Count;i++)
            {
                string key = dic.Keys.ElementAt(i);
                string value = dic[key];
                Console.WriteLine($"key:{key}, Value:{value}");
            }
            dic.Clear();
            Console.WriteLine("\nAfter Clearing");

            for (int i = 0; i < dic.Count; i++)
            {
                string key = dic.Keys.ElementAt(i);
                string value = dic[key];
                Console.WriteLine($"key:{key}, Value:{value}");
            }
        }
    }
}
