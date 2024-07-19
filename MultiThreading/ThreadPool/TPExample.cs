using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.ThreadPoolP
{
    public class TPExample
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(MyMethod)
                {
                    Name = "Thread" + i
                };
                thread.Start();
                //ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            }
            Console.ReadLine();
        }
    

        private static void MyMethod(object? state)
        {
            Thread t = Thread.CurrentThread;
            string mes = $"Background: {t.IsBackground}, Threadpool:{t.IsThreadPoolThread}, Thread Id:{t.ManagedThreadId}";
            Console.WriteLine(mes); 
        }
    }
}
