using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.SemaphoreExample
{
    public class SemaphoreDemoExample
    {
        public static Semaphore semaphore = new Semaphore(2, 3);

        static void Main()
        {
            for(int i = 0; i <=10;  i++)
            {
                Thread thread = new Thread(SomeTask)
                {
                    Name = "Thread" + i
                };

                thread.Start();
            }
            Console.ReadLine();
        }

        public static void SomeTask()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "Wants to Enter in critical section in processing");

            try
            {
                semaphore.WaitOne();
                Console.WriteLine("Success:" + Thread.CurrentThread.Name + " is Doing its work");

                Thread.Sleep(5000);

                Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
            }

            finally
            {
                semaphore.Release();
            }
        }
    }
}
