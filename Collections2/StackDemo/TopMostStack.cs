using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.StackDemo
{
    public class TopMostStack
    {
        static void Main()
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push("Venu");
            stack.Push(3.14f);
            stack.Push(true);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total count in stack :{stack.Count}");

            Console.WriteLine($"Top most elements in stack is {stack.Pop()}");
            Console.WriteLine($"Total count in stack :{stack.Count}");
            Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");

            Console.WriteLine($"Total elements present in stack : {stack.Count}");

            if(stack.Contains("Venu"))
            {
                Console.WriteLine("Element is found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Stack cloneStack =  (Stack)stack.Clone();

            Console.WriteLine("\n Cloned stack elements");
            foreach (var item in cloneStack)
            {
                Console.Write(item);
            }

            Console.WriteLine("Copy elements in stack");

            object[] st = new object[4];
            stack.CopyTo(st, 0);
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
