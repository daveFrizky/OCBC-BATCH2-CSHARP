using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi4
{
    public class data2
    {
        public static void Main()
        {
            string[] contoh=new string [4]{
                "Motherboard","Processor","Power Supply","Video Card"
            };
            System.Console.WriteLine("Menamppilkan semua data dalam array\n");
            
            foreach (string contoh1 in contoh)
            {
                System.Console.WriteLine(contoh1);
            }
            System.Console.WriteLine("Press any key to continue....");
        }
    }
}