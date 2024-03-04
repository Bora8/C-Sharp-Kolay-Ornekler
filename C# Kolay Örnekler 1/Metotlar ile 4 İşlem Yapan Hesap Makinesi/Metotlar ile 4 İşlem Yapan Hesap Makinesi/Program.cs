using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_ile_4_İşlem_Yapan_Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz(+,-,*,/)");
            string islem = Console.ReadLine();
            Console.WriteLine("1.sayıyı giriniz.");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz.");
            int s2 = int.Parse(Console.ReadLine());

            Metot mt = new Metot();
            switch (islem)
            {
                case "+" :  mt.toplama(s1, s2); break;
                case "-" :  mt.cikarma(s1, s2); break;
                case "*" :  mt.carpma(s1, s2); break;
                case "/" :  mt.bolme(s1, s2); break;
            }
            Console.Read();
        }
    }
}
