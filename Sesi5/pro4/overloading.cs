using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro4
{
    public class overloading
    {
        public string nama;
        public double nomor_telepon;
        public void print(string nama)
        {
            this.nama = nama;
            Console.WriteLine("Namanya adalah : {0}", this.nama);
        }
        public void print(double nomor_telpon)
        {
            this.nomor_telepon = nomor_telpon;
            System.Console.WriteLine("Nomor HP: {0}", this.nomor_telepon);
        }
    }
}