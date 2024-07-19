using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.ThreadPool
{
    public class ForegroundBackgroundThread
    {
        static void Main()
        {
            Thread thread1 = new Thread(Method1)
            {
                IsBackground = true
            };
            Console.WriteLine($"Thread1 is background thread: {thread1.IsBackground}");
            thread1.Start();

            Console.WriteLine("main Thread Exited");

        }

        private static void Method1()
        {
            Console.WriteLine("Method1 Started");
            for (int i = 0; i <= 5; i++) 
            {
                Console.WriteLine("Method1 is in progress!");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Method1 Existed");
            Console.WriteLine("Press any Key to exit");
            Console.ReadLine();
        }
    }
}
