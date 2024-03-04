using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcının_Girdiği_Kadar_Sayıyı_Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane sayı toplayacaksınız?");
            int sayı = int.Parse(Console.ReadLine());
            int toplam = 0;
            for (int i = 0; i<sayı; i++)
            {
                Console.WriteLine((i+1)+".sayıyı giriniz.");
                int ksayısı = int.Parse(Console.ReadLine());
                toplam = toplam + ksayısı;
            }
            Console.WriteLine("Sonuç="+toplam);
            Console.Read();
        }
    }
}
