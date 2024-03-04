using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basamaklara_Ayırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği 3 basamaklı sayıyı basamaklarına ayırma
            BaşaDön:
            Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            
            if (sayı.ToString().Length == 3)
            {
                int yüzler = sayı / 100; int yüzlerkalan = sayı % 100;
                int onlar = yüzlerkalan / 10;
                int birler = yüzlerkalan % 10;

                Console.WriteLine("Yüzler Basamağı:" + "" + yüzler);
                Console.WriteLine("Onlar Basamağı:" + "" + onlar);
                Console.WriteLine("Birler Basamağı:" + "" + birler);
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı 3 basamaklı değil.");
                goto BaşaDön;
            }

            Console.Read();
        }
    }
}
