using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Threadclasses
    {
        static void Main()
        {
            Thread t1 = new Thread(DisplayName);
            t1.Start();
            Console.ReadLine();
        }
        static void DisplayName()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method1: " + i);
            }
        }
        //static void Main()
        //{
        //    ThreadStart obj = new ThreadStart(DisplayNumber);
        //    Thread t1 = new Thread(obj);
        //    t1.Start();
        //    Console.ReadLine();
        //}
        //static void DisplayNumber()
        //{

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Method1: " + i);
        //    }
        //}
        //static void Main()
        //{
        //    Thread t1 = new Thread(() =>
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("Method1: " + i);
        //        }
        //    });
        //    t1.Start();
        //    Console.ReadLine() ;
        //}

        
    }
}
