using Collections2.GenericCollections.HashListDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.GenericCollections.DictionaryDemo
{
    public class ConvertToDictionary
    {
        static void Main()
        {
            Student[] students = new Student[3];

            students[0] = new Student() { Id= 101, Name="Venu", Branch= "ECE" };

            students[1] = new Student() { Id= 102, Name="Sai", Branch= "CSE" };
            students[2] = new Student() { Id = 103, Name="Ravi", Branch = "BSC" };
            

            Dictionary<int, Student> dictionaryStudents = students.ToDictionary(std => std.Id, std => std);

            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.Id}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }


        }

        public class Studnet
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Branch { get; set; }
        }
    }
}
