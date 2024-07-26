using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections2.GenericCollections.HashListDemo
{
    public class ComplexTypeExampels
    {
        static void Main()
        {
            HashSet<Student> student = new HashSet<Student>()
            {
                new Student() {Id = 101, Name ="Venu", Branch ="CSE"},
                new Student(){ Id = 101, Name ="Anurag", Branch="CSE"},
                new Student(){ Id = 102, Name ="Mohanty", Branch="CSE"},
                new Student(){ Id = 103, Name ="Sambit", Branch="ETC"}
            };

            Console.WriteLine("List of Elements");

            foreach(var item in student)
            {
                Console.WriteLine($"Id:{item.Id},Name:{item.Name},Branch:{item.Branch}");
            }
        }
    }

    public class Student :IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public bool Equals(Student obj)
        {
            return this.Id.Equals(obj.Name);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}

