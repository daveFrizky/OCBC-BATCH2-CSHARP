using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi_3
{
    public class Logika4
    {
        public static void Main()
        {
            Console.Write("Nilai: ");
            double nilai=Convert.ToDouble(Console.ReadLine());

            if (nilai>=85)
            {
                Console.WriteLine("Kamu mendapat grade A");
            }
            else if (nilai>=65)
            {
                Console.WriteLine("Kamu mendapat grade B");
            }
            else if (nilai>=45)
            {
                Console.WriteLine("Kamu mendapat grade C");
            }
            else if (nilai<45)
            {
                Console.WriteLine("Kamu mendapat grade D");
            }
        }
    }
}