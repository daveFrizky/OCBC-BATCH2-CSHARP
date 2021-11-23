using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi_3
{
    public class Logika2
    {
        public static void Main()
        {
            int nilai=75;

            if (nilai<60)
            {
                Console.WriteLine("Nilai kamu C");
            }
            else if (nilai<80)
            {
                Console.WriteLine("Nilai kamu B");
            }
            else
            {
                Console.WriteLine("Nilai kamu A");
            }
        }
    }
}