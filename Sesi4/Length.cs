using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi4
{
    public class Length
    {
        public static void Main()
        {
            int[] angka = new int[10];
            System.Console.WriteLine("Panjang array angka adalah "+ angka.Length);

            for (int i = 0; i < angka.Length; i++)
            {
                angka[i]=i*i;
            }
            System.Console.Write("Berikut adalah array angka: ");

            for (int i = 0; i < angka.Length; i++)
                Console.Write(angka[i]+" ");
            
            System.Console.WriteLine();
        }
    }
}