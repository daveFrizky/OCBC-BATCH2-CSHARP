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
            System.Console.Write("Masukkan tinggi segitiga: ");
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            string angka="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n * 2 - 1; j++)
                {
                    if (j < n - i - 1 || j >= n + i) //segitiga kiri || kanan
                    {
                        System.Console.Write(" ");
                    }
                    else
                    {
                        if (j < n) //dibawah inputan angka++
                        {
                            temp++;
                            if (temp == angka.Length+1)
                                temp=(angka.Length)-temp+2;
                            System.Console.Write(angka[temp-1]);
                        }
                        else //dibawah inputan angka--
                        {
                            temp--;
                            if (temp==0 )
                                temp =angka.Length;                             
                            System.Console.Write(angka[temp-1]);  
                        }
                    }
                }
                System.Console.Write("\n");
                temp = 0;
            }
        }
    }
}