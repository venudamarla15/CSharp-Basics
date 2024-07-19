using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MutexExample
    {
        private static Mutex mutex = new Mutex();
        static void Main()
        {
           for(int i = 0; i<=5;  i++)
           {
                Thread thread = new Thread(MutexDemo)
                {
                    Name = "Thread" + i
                };
                thread.Start();
           }

           Console.ReadKey();
        }

        static void MutexDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name +"" +":wants to enter critical section in processing");

            if(mutex.WaitOne(1000) )
            {
                try
                {

                    Console.WriteLine("SUccess: " + Thread.CurrentThread.Name + "is processing Now");

                    Thread.Sleep(2000);

                    Console.WriteLine("exit:" + Thread.CurrentThread.Name + " is completed it task");

                }
                finally
                {
                    mutex.ReleaseMutex();
                    Console.WriteLine(Thread.CurrentThread.Name + " Has Released the mutex");
                }
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.Name + " will not acquire the mutex");
            }
        }

        ~MutexExample()
        {
            mutex.Dispose();
        }
    }
}
