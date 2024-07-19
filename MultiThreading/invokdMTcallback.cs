using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class invokdMTcallback
    {
        static void Main()
        {
            ResultCallbackDelegate resulCallbackDelegate = new ResultCallbackDelegate(ResultCallbackMethod);
            int Number = 10;

            NumberHelper obj = new NumberHelper(Number, resulCallbackDelegate);
            
            Thread t1 = new Thread(new ThreadStart(obj.CalculateSum));
            t1.Start();
            Console.ReadLine(); 
        }

        public static void ResultCallbackMethod(int Result)
        {
            Console.WriteLine("The Result is" + Result);
        }
        

    }
}
