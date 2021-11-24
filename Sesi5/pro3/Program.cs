using System;

namespace pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            pesawat pesawat=new pesawat();
            pesawat_tempur pswtTempur=new pesawat_tempur();

            pesawat.nama="Helly";
            pesawat.jumlahRoda=3;
            pesawat.ketinggian="1000 kaki";
            pesawat.jumlahPenumpang="3 penumpang";
            pswtTempur.nama="AZ500TPU";
            pswtTempur.jumlahRoda=5;
            pswtTempur.ketinggian="200 kaki";
            pswtTempur.jumlahPenumpang="2 penumpang plus kopilot dan assiten";

            pesawat.terbang();
            pswtTempur.terbangTinggi();
            Console.Read();
        }
    }
}
