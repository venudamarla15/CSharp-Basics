using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultiThreading
{
    public class MonitorExample
    {
        private static readonly object lockPrintNumber = new object();

        public static void PrintNumbers()
        {
            TimeSpan timeout = TimeSpan.FromMilliseconds(1000);
            //Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
            bool IsLockTaken = false;

            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
                Monitor.TryEnter(lockPrintNumber, timeout, ref IsLockTaken);
                if (IsLockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");

                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine(i + ",");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Lock was not acquired");
                }
                
            }
            finally
            {
                if(IsLockTaken)
                {
                    Monitor.Exit(lockPrintNumber);
                    Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical sextion");
                }
            }
            
        }

        static void Main()
        {
            Thread[] threads = new Thread[3];
            for(int i = 0; i<3;i++)
            {
                threads[i] = new Thread(PrintNumbers)
                {
                    Name = "Child Thread " + i
                };
            }

            foreach(Thread thread in threads)
            {
                thread.Start();
            }
            Console.ReadLine();

        }
    }
}
