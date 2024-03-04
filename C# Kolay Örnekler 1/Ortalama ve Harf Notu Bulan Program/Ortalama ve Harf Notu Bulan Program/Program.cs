using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_ve_Harf_Notu_Bulan_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize ağırlıklarını parantez içindeki formatta giriniz(0.4-0.2-0.4)");
            string input = Console.ReadLine();

            if (input.Length >= 10)
            {
                double ilk1 = Convert.ToDouble(input.Substring(0, 3));
                double ikinci1 = Convert.ToDouble(input.Substring(4, 3));
                double final1 = Convert.ToDouble(input.Substring(8, 3));

                Console.WriteLine("1.vize sonucunuz");
                int ilk = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.vize sonucunuz");
                int ikinci = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("final sonucunuz");
                int final = Convert.ToInt32(Console.ReadLine());
                double ortalama = ((ilk * ilk1)+ (ikinci * ikinci1)+ (final * final1))/10;
                Console.WriteLine("Ortalamanız="+ortalama);
                if(ortalama >= 90) 
                {
                    Console.WriteLine("AA ile geçtiniz");
                }
                else if (ortalama >= 80)
                {
                    Console.WriteLine("BA ile geçtiniz");
                }
                else if (ortalama >= 70)
                {
                    Console.WriteLine("BB ile geçtiniz");
                }
                else if (ortalama >= 60)
                {
                    Console.WriteLine("CB ile geçtiniz");
                }
                else if (ortalama >= 50)
                {
                    Console.WriteLine("CC ile geçtiniz");
                }
                else if (ortalama >= 40)
                {
                    Console.WriteLine("DC ile geçtiniz");
                }
                else if(ortalama >= 0)
                {
                    Console.WriteLine("FF ile kaldınız");
                }
                else
                {
                    Console.WriteLine("Firdiğiniz notlarda hata olmalı lütfen tekrar giriniz");
                }

            }
            else
            {
                Console.WriteLine("Hatalı bir çıktı girdiniz");
                
            }
            
            Console.Read();
        }
    }
}
