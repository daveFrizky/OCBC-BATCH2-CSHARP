using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment
{
    public class soal1
    {
        public static void Main()
        {
            // System.Console.Write("Masukkan tinggi segitiga: ");
            // int n=int.Parse(Console.ReadLine());
            int n = 10;
            char ch = 'A';
            int i, j, k, m;
            for (i = 1; i <= n; i++)
            {
                for (j = 5; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }
    }
}