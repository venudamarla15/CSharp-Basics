using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2.QueueDemo
{
    internal class CreateaQuueu
    {
        static void Main()
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue("Venu");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count in Queue is {queue.Count}");

            Console.WriteLine($"Count after remove is{queue.Dequeue()}");

            Console.WriteLine("Queue after deque");
            foreach (var item in queue)
            {

                Console.WriteLine(item);
            }

            //queue.Clear();
            Console.WriteLine($"Count in Queue after clear is {queue.Count}");

            Queue cloneQueue = (Queue)queue.Clone();

            Console.WriteLine("\nCloned Queue Elements:");
            foreach (var item in cloneQueue)
            {
                Console.WriteLine(item);
            }

            object[] ct = new object[4];
            cloneQueue.CopyTo(ct, 0);

            Console.WriteLine("\nQueue Copy Array Elements:");
            foreach (var item in ct)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        
    }
}
