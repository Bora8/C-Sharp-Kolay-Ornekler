using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bileşik_Faiz_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anaparayı giriniz");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Süre Cinsini Seçiniz(Yıl için 1, Ay için 2, Gün için 3)");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Süre Cinsine Göre Zamanı Giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yıllık Faiz Oranını Giriniz(Örn. 0,03)");
            double i = Convert.ToDouble(Console.ReadLine());
            double sonuc = 1;
            double toplam;
            double ii;
            if(B == 1)
            {
                for(int j=0; j < n; j++)
                {
                    sonuc = sonuc * (1 + i);
                }
                toplam = A * sonuc;
                Console.WriteLine(toplam);
            }
            else if (B == 2)
            {
                ii = i / 12 * n;
                ;
                for (int j = 0; j < n; j++)
                {
                    sonuc = sonuc * (1 + ii);
                }
                toplam = A * sonuc;
                Console.WriteLine(toplam);
            }
            else if (B == 3)
            {
                ii = i / 360 * n;
                for (int j = 0; j < n; j++)
                {
                    sonuc = sonuc * (1 + ii);
                }
                toplam = A * sonuc;
                Console.WriteLine(toplam);
            }
            Console.Read();
        }
    }
}
