using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.SemaphoreExample
{
    public class SemaphoreDemo
    {

        public static Semaphore semaphore = null;

        static void Main()
        {
            try
            {
                semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            }
            catch (Exception ex)
            {
                semaphore = new Semaphore(2,3, "SemaphoreDemo");
            }
            Console.WriteLine("External Thread trying to acquiring");

            semaphore.WaitOne();
            Console.WriteLine("Exteranl Thread is acquire");

            Console.ReadLine();

            semaphore.Release();
        }
    }
}
