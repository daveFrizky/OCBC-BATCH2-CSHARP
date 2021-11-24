using System;

namespace pro5
{
    class Program
    {
        public int bilangan1,bilangan2;
        public void bilangan(int angka1,int angka2){
            bilangan1=angka1;
            bilangan2=angka2;
        }
        public virtual void penjumlahandll(){
            System.Console.WriteLine("Overloading 1.....----->>>>>>>>");
            System.Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1}= {2}",bilangan1,bilangan2,bilangan1+bilangan2);
            System.Console.WriteLine("Hasil perkalian angka {0} dan angka {1}= {2}",bilangan1,bilangan2,bilangan1*bilangan2);

        }
    }
    class overide:Program{
        
        public override void penjumlahandll(){
            System.Console.WriteLine("Overloading 2.....----->>>>>>>>");
            System.Console.WriteLine("Hasil pembagian angka {0} dan angka {1}= {2}",bilangan1,bilangan2,bilangan1/bilangan2);
            System.Console.WriteLine("Hasil pengurangan angka {0} dan angka {1}= {2}",bilangan1,bilangan2,bilangan1-bilangan2);
        }
        static void Main(string[] args)
        {
            Program overiding=new Program();
            overiding.bilangan(10,5);
            overiding.penjumlahandll();
            overiding=new overide();
            overiding.bilangan(20,5);
            overiding.penjumlahandll();
            Console.Read();
        }
    }
}
