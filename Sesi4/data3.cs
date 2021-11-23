using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi4
{
    public class data3
    {
        public static void Main()
        {
            int t,i;
            int[,] tabel=new int[3,4];

            for ( t = 0; t < 3; ++t)
            {
                for ( i = 0; i < 4; ++i)
                {
                    tabel[t,i]=(t*4)+i+1;
                    Console.Write(tabel[t,i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}