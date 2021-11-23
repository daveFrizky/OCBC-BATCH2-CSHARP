using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sesi_3
{
    public class Logika5
    {
        public static void Main()
        {
            int nilai;
            nilai=7;
            switch (nilai)
            {
                case 1:{
                    System.Console.WriteLine("Januari");
                break;}
                case 2:{
                    System.Console.WriteLine("Febuari");
                break;}
                case 3:{
                    System.Console.WriteLine("Maret");
                break;}
                case 4:{
                    System.Console.WriteLine("April");
                break;}
                case 5:{
                    System.Console.WriteLine("Mei");
                break;}
                case 6:{
                    System.Console.WriteLine("Juni");
                break;}
                case 7:{
                    System.Console.WriteLine("Juli");
                break;}
                case 8:{
                    System.Console.WriteLine("Agustus");
                break;}
                case 9:{
                    System.Console.WriteLine("September");
                break;}
                case 10:{
                    System.Console.WriteLine("Oktober");
                break;}
                case 11:{
                    System.Console.WriteLine("November");
                break;}
                case 12:{
                    System.Console.WriteLine("Desember");
                break;}
                default:{
                    System.Console.WriteLine("Bulan ?");
                    break;}
            }
            Console.ReadLine();
            
        }
    }
}