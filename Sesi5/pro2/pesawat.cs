using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro2
{
    public class pesawat
    {
            public string nama;
            private string ketinggian1;
            public string ketinggian
            {
                get { return ketinggian1; }
                set { ketinggian1 = value; }
            }
            public void terbang()
            {
                System.Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
            }
            public void SudahTerbang()
            {
                System.Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
            }
        
    }
}