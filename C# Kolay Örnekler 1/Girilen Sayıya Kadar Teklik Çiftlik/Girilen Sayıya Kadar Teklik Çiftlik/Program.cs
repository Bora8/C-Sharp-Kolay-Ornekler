using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayıya_Kadar_Teklik_Çiftlik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz..");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int tekler = 0; int ciftler = 0;
            for (int i = 0; i < sayı; i++)
            {
                if (i % 2 == 0)
                {
                    ciftler = ciftler + i;
                }
                else if (i % 2 == 1)
                {
                    tekler = tekler + i;
                }
            }
            Console.WriteLine(sayı + " sayısına kadar olan tek sayıların toplamı="+tekler);
            Console.WriteLine(ciftler + " sayısına kadar olan çift sayıların toplamı=" + ciftler);
            Console.Read();
        }
    }
}
