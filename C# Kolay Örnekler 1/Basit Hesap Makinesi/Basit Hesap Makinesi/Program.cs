
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapacağınız işlemi seçiniz(+,-,*,/,kare,küp,karekök)");
            string işlem = Console.ReadLine();

            Console.WriteLine("Sayı giriniz..");
            double ilk = Convert.ToInt32(Console.ReadLine());

            double sonuc = 0;
            if (işlem == "+" || işlem == "-" || işlem == "*" || işlem == "/")
            {
                Console.WriteLine("2.Sayıyı giriniz..");
                double son = Convert.ToInt32(Console.ReadLine());
                if (işlem == "+")
                {
                    sonuc = ilk + son;
                    Console.Write(ilk + "+" + son + "=" + sonuc);
                }
                else if (işlem == "-")
                {
                    sonuc = ilk - son;
                    Console.Write(ilk + "-" + son + "=" + sonuc);
                }
                else if (işlem == "*")
                {
                    sonuc = ilk * son;
                    Console.Write(ilk + "*" + son + "=" + sonuc);
                }
                else if (işlem == "/")
                {
                    sonuc = ilk / son;
                    Console.Write(ilk + "/" + son + "=" + sonuc);
                }
            }
            else if(işlem == "kare" || işlem == "küp" || işlem == "karekök")
            {
                if (işlem == "kare")
                {
                    sonuc = ilk * ilk;
                    Console.WriteLine(ilk + " sayısının karesi="+sonuc);
                }
                else if (işlem == "küp")
                {
                    sonuc = ilk * ilk * ilk;
                    Console.WriteLine(ilk + " sayısının küpü=" + sonuc);
                }
                else if (işlem == "karekök")
                {
                    sonuc = Math.Sqrt(ilk);
                    Console.WriteLine(ilk + " sayısının karekökü=" + sonuc);
                }

            }
            Console.Read();
        }
    }
}
