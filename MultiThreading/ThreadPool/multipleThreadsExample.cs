using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.ThreadPool
{
    public class multipleThreadsExample
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Method1)
            {

            };

            Console.WriteLine($"Thread1 is a Background thread:  {thread1.IsBackground}");
            thread1.Start();
            Console.WriteLine("Main Thread Exited");
        }

        
            
        private static void Method1(object? obj)
        {
            Console.WriteLine("Method 1 Started");
            Thread thread2 = new Thread(Mehtod2)
            {
                IsBackground = true
            };
            thread2.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Method1 Exited");
        }

        private static void Mehtod2(object? obj)
        {
            Console.WriteLine("Method2 Started");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method2 is in Progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method2 Exited");
            Console.WriteLine("Press any key to Exit.");
            Console.ReadKey();
        }
    }
}
