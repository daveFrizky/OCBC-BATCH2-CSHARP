using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment
{
    public class soal2
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Masukkan tinggi segitiga: ");
            int n = int.Parse(Console.ReadLine());
            int temp = 0;

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
                        if (j < n) //sebelum titik tengah angka++
                        {
                            temp++;
                            if (temp == 10)
                                temp = 9 - temp + 2;
                            System.Console.Write(temp);
                        }
                        else //setelah titik tengah angka--
                        {
                            temp--;
                            if (temp == 0)
                                temp = 9;
                            System.Console.Write(temp);
                        }
                    }
                }
                System.Console.Write("\n");
                temp = 0;
            }
        }
    }
}