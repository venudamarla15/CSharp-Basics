using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.HashtableDemo
{
    public class UpdateHashtable
    {
        static void Main()
        {
            Hashtable emp = new Hashtable
            {
                 { "EId", 1001 },
                { "Name", "Venu" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };

            string empName = (string)emp["Name"];
            int empSalary = (int)emp["Salary"];

            Console.WriteLine("Before Updating Name and salary");
            Console.WriteLine($"Employee Name: {empName}");
            Console.WriteLine($"Employee Salary: {empSalary}");

            emp["Name"] = "Sai";
            emp["Salary"] = 10000;

            Console.WriteLine("\n After Update");
            empName = (string)emp["Name"];
            empSalary = (int)emp["Salary"];

            Console.WriteLine($"Employee Name: {empName}");
            Console.WriteLine($"Employee Salary: {empSalary}");

            Console.ReadKey();
        }
    }
}
