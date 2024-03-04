using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Otopark Uygulaması
            Console.WriteLine("Araç Tipini Giriniz(Taksi, Minibüs, Ticari Araç):");
            string tip = Console.ReadLine();
            Console.WriteLine("Aracın Otoparkta Kaldığı Saati Giriniz:");
            int saat = Convert.ToInt32(Console.ReadLine());
            double ücret = 0;
            if(tip.ToUpper() == "TAKSİ")
            {
                ücret = 5;
                for (int i = 1; i < saat; i++)
                {
                    ücret = ücret + (ücret * 0.2 + ücret);
                }
            }
            else if (tip.ToUpper() == "MİNİBÜS")
            {
                ücret = 6;
                for (int i = 1; i < saat; i++)
                {
                    ücret = ücret + (ücret * 0.215 + ücret);
                }
            }
            else if (tip.ToUpper() == "TİCARİ ARAÇ")
            {
                ücret = 6.5;
                for (int i = 1; i < saat; i++)
                {
                    ücret = ücret + (ücret * 0.25 + ücret);
                }
            }
            string sonuç = ücret.ToString("F2");
            Console.WriteLine("Ödemeniz Gereken Ücret: "+sonuç);
            Console.Read();
        }
    }
}
