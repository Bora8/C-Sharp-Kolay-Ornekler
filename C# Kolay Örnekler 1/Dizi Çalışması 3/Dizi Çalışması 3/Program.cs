using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Çalışması_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            int çifttoplam = 0; int tektoplam = 0; int çiftsayısı = 0; int teksayısı = 0;
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine((j + 1) + ".elemanı giriniz :");
                dizi[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    çifttoplam = çifttoplam + dizi[i];
                    çiftsayısı += 1;
                }
                else if (dizi[i] % 2 != 0)
                {
                    tektoplam = tektoplam + dizi[i];
                    teksayısı += 1;
                }
            }
            Console.WriteLine("Tek sayıların ortalaması: " + (float)tektoplam / teksayısı);
            Console.WriteLine("Çift sayıların ortalaması: " + (float)çifttoplam / çiftsayısı);
            Console.Read();
        }
    }
}
