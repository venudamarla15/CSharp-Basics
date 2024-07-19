using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class JoinMethodThread
    {
        static void Main()
        {
            Console.WriteLine("Main Thread started:");
            Thread t1 = new Thread(Mehtod1);
            Thread t2 = new Thread(Mehtod2);
            Thread t3 = new Thread(Mehtod3);

            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();

            if (t1.Join(TimeSpan.FromSeconds(3)))
            {
                Console.WriteLine("Thread 1 executon complete in 3 sec");
            }
            else
            {
                Console.WriteLine("Thread 1 executon is not complete in 3 sec");
            }
            if (t2.Join(3000))
            {
                Console.WriteLine("Thread 2 executon complete in 3 sec");
            }
            else
            {
                Console.WriteLine("Thread 2 executon is not complete in 3 sec");
            }
            if (t3.IsAlive)
            {
                Console.WriteLine("Thread 3 method 3 is alive and exectuting");
            }
           else
            {
                Console.WriteLine("Thread3 Method3 Completed its work");
            }

            Console.WriteLine("Main Thread Ended:");

            static void Mehtod1()
            {
                Console.WriteLine("Method1 : Thread-1 started:");
                Thread.Sleep(3000);
                Console.WriteLine("Method1: thread-1 ended:");
            }
            static void Mehtod2()
            {
                Console.WriteLine("Method2 : Thread-2 started:");
                Thread.Sleep(4000);
                Console.WriteLine("Method2: thread-2 ended:");
            }
            static void Mehtod3()
            {
                Console.WriteLine("Method3 : Thread-3 started:");
                Thread.Sleep(TimeSpan.FromSeconds(3));
                Console.WriteLine("Method3: thread-3 ended:");
            }
        }
    }
}
