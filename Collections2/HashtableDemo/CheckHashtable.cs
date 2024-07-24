using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.HashtableDemo
{
    public class CheckHashtable
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();

            ht.Add("Id", 101);
            ht.Add("Name", "James"); //Here key is Name and value is James
            ht.Add("Job", "Developer");
            ht.Add("Salary", 3500);
            ht.Add("Location", "Mumbai");
            ht.Add("Dept", "IT");
            ht.Add("EmailID", "a@a.com");

            Console.WriteLine("Is Email key Exist : " + ht.Contains("Email"));
            Console.WriteLine("Is Department exitst :" + ht.ContainsKey("Department"));
            Console.WriteLine("Is Name Exist :" + ht.ContainsKey("Name"));
            Console.WriteLine("Is Name value exist :" + ht.ContainsValue("James"));

            Console.ReadLine();
        }
    }
}
