using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment
{
    public class soal4
    {
        static void Main()
        {
            System.Console.Write("Enter a Number: ");
            string n = Console.ReadLine();
            if (n.All(Char.IsDigit))
            {
                System.Console.Write("Reversed Number: ");
                for (int i = n.Length - 1; i >= 0; i--)
                {
                    System.Console.Write(n[i]);
                }
            }
            else
                System.Console.Write("Invalid Input");

        }
    }
}