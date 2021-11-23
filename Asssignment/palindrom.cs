using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment
{
    public class palindrom
    {
        static void Main(){
            System.Console.Write("Enter a Word: ");
            string n = Console.ReadLine();
            string temp="";
            
            for (int i = n.Length - 1; i >= 0; i--)
            {
                temp+=n[i];
            }

            if (temp==n)
                System.Console.Write(n+" Is Palindrome");
            else
                System.Console.Write(n+" Is not Palindrome");
           
        }
    }
}