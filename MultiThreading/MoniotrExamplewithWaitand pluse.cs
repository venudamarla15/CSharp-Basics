using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MoniotrExamplewithWaitandpluse
    {
        const int numberLimit = 20;
        static readonly object _lockMoniotr = new object();

        static void Main()
        {
            Thread EvenThread = new Thread(printEvenNumbers);
            Thread OddThread = new Thread(printOddNumbers);

            EvenThread.Start();

            Thread.Sleep(1000);

            OddThread.Start();

            OddThread.Join();
            EvenThread.Join();

            Console.WriteLine("\nMain method completed");
            Console.ReadKey();
        }

        static void printEvenNumbers()
        {
            try
            {
                Monitor.Enter(_lockMoniotr);
                for(int i = 0; i<=numberLimit; i= i + 2)
                {
                    Console.WriteLine($"{i}");

                    Monitor.Pulse(_lockMoniotr);

                    bool isLast = false;

                    if (i == numberLimit) 
                    {
                        isLast = true;
                    }
                    if(!isLast)
                    {
                        Monitor.Wait(_lockMoniotr);
                    }
                }
       
            }
            finally
            {
                Monitor.Exit(_lockMoniotr);
            }
        }

        static void printOddNumbers()
        {
            try
            {
                Monitor.Enter(_lockMoniotr);
                for(int i = 1; i <= numberLimit; i= i + 2)
                {
                    Console.WriteLine($"{i}");

                    Monitor.Pulse(_lockMoniotr);

                    bool isLast = false;

                    if(i == numberLimit - 1)
                    {
                        isLast = true;
                    }
                    if(!isLast)
                    {
                        Monitor.Wait(_lockMoniotr);
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lockMoniotr);
            }
        }
    }
}
