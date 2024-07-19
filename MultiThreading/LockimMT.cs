using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public static class LockimMT
    {
        private static object Lock = new object();
        static void Main()
        {
            Thread t1 = new Thread(DisplayMessage);
            Thread t2 = new Thread(DisplayMessage);
            Thread t3 = new Thread(DisplayMessage);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine(); 
        }

        //private static readonly object lockObject = new object();
        static void DisplayMessage()
        {
            lock(Lock)
            {
                Console.Write("[welcom to the");
                Thread.Sleep(1000);
                Console.WriteLine("World of .NET!]");
            }
            
        }
    }
}
