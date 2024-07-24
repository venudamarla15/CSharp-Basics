using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.TwoDimensionalArray
{
    public class RecatngleArrays
    {
        static void Main()
        {
            int[,] RectangleArray = new int[4, 5];

            int a = 0;

            foreach(int i in RectangleArray)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\n");

            for(int i =0; i<RectangleArray.GetLength(0); i++)
            {
                for(int j =0; j<RectangleArray.GetLength(1); j++)
                {
                    a += 5;
                    RectangleArray[i, j] = a;
                }
            }

            for(int i =0;i<RectangleArray.GetLength(0); i++)
            {
                for(int j =0;j<RectangleArray.GetLength(1);j++)
                {
                    Console.WriteLine(RectangleArray[i, j] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
