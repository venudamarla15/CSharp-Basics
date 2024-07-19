using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class SingleThread
    {
        static void Main()
        {
            Console.WriteLine("main Thread is started:");

            Thread t1 = new Thread(Method1);
            {
                t1.Name = "Thread1";
            }
            Thread t2 = new Thread(Method2);
            {
                t2.Name = "Thread 2";
            }
            Thread t3 = new Thread(Method3);
            {
                t3.Name = "Thread 3";
            }
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread ended");
            Console.ReadLine();

        }

        static void Method1()
        {
            Console.WriteLine("Method1 thread started: " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("method1:"+i);
            }
            Console.WriteLine("Method1 thread Ended: " + Thread.CurrentThread.Name);
        }
        static void Method2()
        {
            Console.WriteLine("Method2 thread started: " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("method2:" + i);
                if(i == 3)
                {
                    Console.WriteLine("Db operations start:");
                    Thread.Sleep(10000);
                    Console.WriteLine("Dboperations ends");
                }
                Console.WriteLine("Method2 thread Ended: " + Thread.CurrentThread.Name);
            }

        }
        static void Method3()
        {
            Console.WriteLine("Method3 thread started: " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("method3:" + i);
            }
            Console.WriteLine("Method3 thread Ended: " + Thread.CurrentThread.Name);
        }
    }
}
