using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment
{
    public class soal5
    {
        static void Main()
        {
            System.Console.Write("Enter a Number: ");
            string n = Console.ReadLine();
            string[] arr = new string[10]{
                "zero","one","two","three","four","five","six","seven","eight","nine"
            };
            if (n.All(Char.IsDigit))
            {
                for (int i = 0; i < n.Length; i++)
                {
                    int temp = int.Parse(n[i].ToString());
                    System.Console.Write(arr[temp]+" ");
                }
            }
            else
                System.Console.Write("Invalid Input");
        }
    }
}