using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi4
{
    public class data4
    {
        public static void Main()
        {
            int[,] data4={
                {1,1},
                {2,4},
                {3,9},
                {4,16},
                {5,25},
                {6,36},
                {7,49},
                {8,64},
                {9,81},
                {10,100},
            };

            int i,t;
            for ( t = 0; t < 10; t++)
            {
                for ( i = 0; i < 2; i++)
                {
                    Console.Write(data4[t,i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}