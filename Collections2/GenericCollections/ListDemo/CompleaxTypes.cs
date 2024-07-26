using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.ListDemo
{
    public class CompleaxTypes
    {
        static void Main()
        {
            Employee emp1 = new Employee() { Id = 101, Name = "Venu", Gender = "Male", Salary = 5000 };
            Employee emp2 = new Employee() { Id = 102, Name = "Sai Saranya", Gender = "Female", Salary = 4000 };
            Employee emp3 = new Employee() { Id = 103, Name = "Ravi", Gender = "Male", Salary = 6000 };

            List<Employee> list = new List<Employee>();

            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);

            Console.WriteLine("Reterivign the employee by index");

            Employee FirstEmployee = list[0];
            Console.WriteLine($"ID = {FirstEmployee.Id}, Name = {FirstEmployee.Name}, Gender = {FirstEmployee.Gender}, Salary = {FirstEmployee.Salary}");

            Console.WriteLine("\n Using for Loop");
            for (int i = 0; i < list.Count; i++)
            {
                Employee emp = list[i];
                Console.WriteLine($"Id ={emp.Id}, Name ={emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            }

            Console.WriteLine("\n using foreach loop :");

            foreach (Employee emp in list)
            {
                Console.WriteLine($"Id ={emp.Id}, Name ={emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            }


            Employee emp4 = new Employee() { Id = 104, Name = "Lohitha", Gender = "Female", Salary = 10000 };

            list.Insert(1, emp4);
            //list.InsertRange(2, emp4);
            Console.WriteLine("\n Insert New Employee");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"Id ={emp.Id}, Name ={emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            }

            list.Sort();
            Console.WriteLine("\n after sorting");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"Id ={emp.Id}, Name ={emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            }

            //using linq
            list = list.OrderByDescending(e => e.Id).ToList();
            Console.WriteLine("\n after sorting with linq ");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"Id ={emp.Id}, Name ={emp.Name}, Gender = {emp.Gender}, Salary = {emp.Salary}");
            }


        }
    }

    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee obj)
        {
            if (this.Salary > obj.Salary)
            {
                return 1;
            }
            else if (this.Salary < obj.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
