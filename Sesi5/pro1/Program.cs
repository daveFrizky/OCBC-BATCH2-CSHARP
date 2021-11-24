using System;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            System.Console.Write("Masukkan Merk: ");
            laptop1.merk = Console.ReadLine();
            System.Console.Write("Masukkan Ram: ");
            laptop1.ram = int.Parse(Console.ReadLine());
            System.Console.Write("Masukkan memory: ");
            laptop1.memory = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\n Merk Laptop adalah {0}", laptop1.merk);
            System.Console.WriteLine("\n Kapasitas Ram ada {0}", laptop1.ram);
            System.Console.WriteLine("\n Kapasitas Memory ada {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
