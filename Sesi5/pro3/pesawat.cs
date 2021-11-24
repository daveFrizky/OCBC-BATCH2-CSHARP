using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro3
{
    public class pesawat
    {
        public string nama,ketinggian,jumlahPenumpang;
        public int jumlahRoda;
        public void terbang()
        {
            System.Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata", this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
        }
    }
    class pesawat_tempur : pesawat
    {
        public void terbangTinggi()
        {
            System.Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata", this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
        }
    }
}