using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.ThreadPoolP
{
    public class perfromaceTest
    {
        static void Main()
        {
            for (int i = 0; i<10; i++)
            {
                MethodWithThread();
                MethodWithThreadPool();
            }

           Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            MethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThread is : " +
                                 stopwatch.ElapsedTicks.ToString());
            
            stopwatch.Reset();
            Console.WriteLine("Execution using Thread Pool");
            stopwatch.Start();
            MethodWithThreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThreadPool is : " +
                                 stopwatch.ElapsedTicks.ToString());
            
            Console.Read();
        }

       
        public static void MethodWithThread()
        {

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(Test);
                t.Start();
            }
        }

        public static void MethodWithThreadPool()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            //}
            

        }

        public static void Test(object? obj)
        {
        }

       
    }
}
