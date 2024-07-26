using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.StackDemo
{
    public class CreateStack
    {
        static void Main()
        {
            Stack stack = new Stack();

            //Adding item to stack.

            stack.Push("Venu");
            stack.Push(101);
            stack.Push(12.5);
            stack.Push(true);
            stack.Push('A');


            Console.WriteLine("Elements in stack");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.Write($"\nCount of Elements in stack: {stack.Count}");
            Console.WriteLine($"\n Deleted Element in: {stack.Pop()}");
            Console.WriteLine($"\nAll Stack Elements After Deletion: Count {stack.Count}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
