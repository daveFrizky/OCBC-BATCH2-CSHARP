using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asssignment
{
    public class Assignment1
    {
        public static void Main()
        {
            char ulang;
            do
            {
                Console.WriteLine("====== WELCOME TO ASSIGNMENT 1 ======\n");

                Console.WriteLine("Nama         : David Chrissando Frizky");
                Console.WriteLine("Kode Peserta : FSDO002ONL001");
                Console.WriteLine("Alamat       : Surabaya\n");

                Console.WriteLine("Pilih Menu: ");
                Console.WriteLine("1. Segitiga Alphabet");
                Console.WriteLine("2. Segitiga Angka");
                Console.WriteLine("3. Faktorial");
                Console.WriteLine("4. Membalik Angka");
                Console.WriteLine("5. Konversi Angka ke kata bhs inggris");
                Console.WriteLine("6. Palindrom");
                Console.WriteLine("7. Exit");

                Console.Write("Masukan Pilihan Menu (1-7): ");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            System.Console.Write("Masukkan tinggi segitiga: ");
                            int n = int.Parse(Console.ReadLine());
                            int temp = 0;
                            string angka = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n * 2 - 1; j++)
                                {
                                    if (j < n - i - 1 || j >= n + i) //segitiga kiri || kanan
                                    {
                                        System.Console.Write(" ");
                                    }
                                    else
                                    {
                                        if (j < n) //dibawah inputan angka++
                                        {
                                            temp++;
                                            if (temp == angka.Length + 1)
                                                temp = (angka.Length) - temp + 2;
                                            System.Console.Write(angka[temp - 1]);
                                        }
                                        else //dibawah inputan angka--
                                        {
                                            temp--;
                                            if (temp == 0)
                                                temp = angka.Length;
                                            System.Console.Write(angka[temp - 1]);
                                        }
                                    }
                                }
                                System.Console.Write("\n");
                                temp = 0;
                            }
                            break;
                        }
                    case 2:
                        {
                            System.Console.Write("Masukkan tinggi segitiga: ");
                            int n = int.Parse(Console.ReadLine());
                            int temp = 0;

                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n * 2 - 1; j++)
                                {
                                    if (j < n - i - 1 || j >= n + i) //segitiga kiri || kanan
                                    {
                                        System.Console.Write(" ");
                                    }
                                    else
                                    {
                                        if (j < n) //sebelum titik tengah angka++
                                        {
                                            temp++;
                                            if (temp == 10)
                                                temp = 9 - temp + 2;
                                            System.Console.Write(temp);
                                        }
                                        else //setelah titik tengah angka--
                                        {
                                            temp--;
                                            if (temp == 0)
                                                temp = 9;
                                            System.Console.Write(temp);
                                        }
                                    }
                                }
                                System.Console.Write("\n");
                                temp = 0;


                            }
                            break;
                        }
                    case 3:
                        {
                            int total = 1;
                            System.Console.Write("Enter any Number: ");
                            int n = int.Parse(Console.ReadLine());
                            if (n > 0 && n <= 31)
                            {
                                for (int i = 1; i <= n; i++)
                                {
                                    total *= i;
                                }
                                System.Console.WriteLine("factorial of " + n + " is: " + total);
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid Input");
                            }
                            break;
                        }
                    case 4:
                        {
                            System.Console.Write("Enter a Number: ");
                            string n = Console.ReadLine();
                            if (n.All(Char.IsDigit))
                            {
                                System.Console.Write("Reversed Number: ");
                                for (int i = n.Length - 1; i >= 0; i--)
                                {
                                    System.Console.Write(n[i]);
                                }
                            }
                            else
                                System.Console.Write("Invalid Input");

                            break;
                        }
                    case 5:
                        {
                            System.Console.Write("Enter a Number: ");
                            string n = Console.ReadLine();

                            string[] arr = new string[10]{
                            "zero","one","two","three","four","five","six","seven","eight","nine"};

                            if (n.All(Char.IsDigit))
                            {
                                for (int i = 0; i < n.Length; i++)
                                {
                                    int temp = int.Parse(n[i].ToString());
                                    System.Console.Write(arr[temp] + " ");
                                }
                            }
                            else
                                System.Console.Write("Invalid Input");
                            break;
                        }
                    case 6:
                        {
                            System.Console.Write("Enter a Word: ");
                            string n = Console.ReadLine();
                            string temp = "";

                            for (int i = n.Length - 1; i >= 0; i--)
                            {
                                temp += n[i];
                            }

                            if (temp == n)
                                System.Console.Write(n + " Is Palindrome");
                            else
                                System.Console.Write(n + " Is not Palindrome");
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    default:{
                        Console.WriteLine("Perhatikan Inputan yang anda masukkan!");
                    break;}
                }
                Console.WriteLine("\n=========================================================");
                Console.Write("Apakah anda ingin keluar (Y/N): ");
                ulang = char.Parse(Console.ReadLine());
                ulang = char.ToUpper(ulang, CultureInfo.CurrentCulture);
            } while (ulang == 'N');

        }
    }
}