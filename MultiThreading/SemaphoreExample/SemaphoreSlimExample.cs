using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.SemaphoreExample
{
    public class SemaphoreSlimExample
    {
        public static SemaphoreSlim semaphore = new SemaphoreSlim(0, 3);

        private static int padding;

        static void Main()
        {
            Console.WriteLine($"{semaphore.CurrentCount} task can enter the semaphore");
            Task[] tasks = new Task[5];

            for (int i = 0; i <= 4; i++)
            {
                //int count = i;
                tasks[i] = Task.Run(() =>
                {
                    Console.WriteLine($"Task {Task.CurrentId} begains and waits for the semaphore");

                    int semaphoreCount;
                    semaphore.Wait();
                    try
                    {
                        Interlocked.Add(ref padding, 100);
                        Console.WriteLine($"Task {Task.CurrentId} enters the semaphore");
                        Thread.Sleep(1000 + padding);
                    }
                    finally
                    {
                        semaphoreCount = semaphore.Release();
                    }
                    Console.WriteLine($"Task {Task.CurrentId} releases the semaphore; previous count: {semaphoreCount}");
                });
                //Thread t = new Thread(() => SemaphoreSlimFunction("Thread " + count, 1000 * count));
                //t.Start();

            }
            Thread.Sleep(1000);
            Console.Write("Main thread calls Release(3) --> ");
            semaphore.Release(3);
            Console.WriteLine($"{semaphore.CurrentCount} tasks can enter the semaphore");
            Task.WaitAll(tasks);
            Console.WriteLine("Main thread Exits");
            Console.ReadLine();
        }

        //public static void SemaphoreSlimFunction(string name, int seconds)
        //{
        //    Console.WriteLine($"{name} waits to access the resource");

        //    semaphore.Wait();

        //    Console.WriteLine($"{name} was granted the access to resource");

        //    Thread.Sleep(seconds);

        //    Console.WriteLine($"{name} is completed");

        //    semaphore.Release();
        //}


    }
}
