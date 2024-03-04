using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Alıştırması_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] dizi = new int[20, 100];
            for (int i = 0; i < 20; i++)
            {
                int toplam = 0;
                for (int j = 0; j < 100; j++)
                {
                    dizi[i,j] = rnd.Next(1,200);
                    toplam = toplam + dizi[i,j];
                }
                Console.WriteLine(i + ".sütundaki sayılar toplamı=" + toplam);
            }
            Console.Read();
        }
    }
}
