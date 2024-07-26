using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections
{
    public class ConversionsExample
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }
        }

        static void Main()
        {
            Employee emp1 = new Employee()
            {
                Id = 101,
                Name = "Venu",
                Gender = "Male",
                Salary = 2000
            };
            Employee emp2 = new Employee()
            {
                Id = 102,
                Name = "Sai Saranya",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                Id = 103,
                Name = "Ravi",
                Gender = "Male",
                Salary = 40000
            };

            // Creating array of EMP

            Employee[] employees = new Employee[3];

            employees[0] = emp1;
            employees[1] = emp2;
            employees[2] = emp3;

            //Convert array to List

            Console.WriteLine("\n Convert arrary to list");

            List<Employee> list = employees.ToList();
            foreach (Employee emp in list)
            {
                Console.WriteLine("Id={0}, Name={1}, Gender ={2}, Salary = {3}\"", emp.Id, emp.Name,emp.Gender, emp.Salary);
            }

            Console.WriteLine("\n convert list to array");

            Employee[] arrayEmployee = list.ToArray();

            foreach(Employee emp in arrayEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}", emp.Id, emp.Name, emp.Gender, emp.Salary);
            }

            Console.WriteLine("\nConverting list to dictionary");

            Dictionary<int, Employee> dictEmployee = arrayEmployee.ToDictionary(employee => employee.Id, emp => emp);
            foreach (KeyValuePair<int, Employee> kvp in dictEmployee)
            {
                Console.WriteLine("key ={0}", kvp.Key);

                Employee emp = kvp.Value;

                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}", emp.Id, emp.Name, emp.Gender, emp.Salary);
            }



        }
    }
}
