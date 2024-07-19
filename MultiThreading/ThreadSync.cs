using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadSync
    {
        static Object lockObject = new Object();
        static void Main()
        {

            Thread t1 = new Thread(SomeMethod);
            {
                t1.Name = "Thread1";
            }
            Thread t2 = new Thread(SomeMethod);
            {
                t2.Name = "Thread2";
            }
            Thread t3 = new Thread(SomeMethod);
            {
                t3.Name = "Thread3";
            }

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }

        static void SomeMethod()
        {
            lock (lockObject)
            {
                Console.Write("[Welcome To The ");
                Thread.Sleep(1000);
                Console.WriteLine("World of Dotnet!]" + Thread.CurrentThread.Name);
            }

        }
    }
}
