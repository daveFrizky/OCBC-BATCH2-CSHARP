using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment
{
    public class soal3
    {
        static void Main()
        {
            int total = 1;
            System.Console.Write("Enter any Number: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n<=31)
            {
                for (int i = 1; i <= n; i++)
                {
                    total *= i;
                }
                System.Console.WriteLine("factorial of " + n + " is: " + total);
            }
            else{
                System.Console.WriteLine("Invalid Input");
            }
        }
    }
}