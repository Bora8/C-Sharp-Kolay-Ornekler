using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OkulSistemi
{
    internal class Program
    {
        /*
       Soru: Bir okul yönetim sistemi simülasyonu için C# konsol uygulaması geliştirin. Bu sistem içinde öğretmenler ve öğrenciler olacak şekilde, temel nesne yönelimli programlama prensiplerini (NYP) kullanın. Sistem şu özelliklere sahip olmalıdır:

       Kapsülleme (Encapsulation): Öğrenci ve öğretmen bilgileri güvenli bir şekilde saklanmalı ve yalnızca tanımlı metotlar aracılığıyla erişilebilir olmalıdır.
       Kalıtım (Inheritance): Öğrenciler ve öğretmenler için genel bir Kisi sınıfından türemiş olmalıdırlar. Her iki sınıf da bazı ortak özellikleri (Isim, Yas gibi) bu temel sınıftan almalıdır.
       Polimorfizm (Polymorphism): Sistem, öğretmen ve öğrenci nesneleri için ortak davranışları olan metotlar tanımlamalı ve bu metotlar alt sınıflarda farklılık gösterebilmelidir.
       Sistemde ayrıca, öğrencilerin notlarını saklayabilecek ve bir öğretmenin tüm öğrencilerinin not ortalamasını hesaplayabilecek yapılar olmalıdır.
       */
        static void Main(string[] args)
        {

            Ogretmen ogretmen1 = new Ogretmen("Ahmet", 40);
            ogretmen1.KendiniTanit();
            
            Ogrenci ogrenci1 = new Ogrenci("Ahmet", 16);
            ogrenci1.Not(49);
            ogrenci1.Not(51);
            ogrenci1.Not(72);
            ogrenci1.KendiniTanit();

            Ogrenci ogrenci2 = new Ogrenci("Aylin", 16);
            ogrenci2.Not(69);
            ogrenci2.Not(92);
            ogrenci2.Not(55);
            ogrenci2.KendiniTanit();

            var ogrenciler = new List<Ogrenci> { ogrenci1, ogrenci2 };
            Console.WriteLine("Öğrencilerin Sınıf Ortalaması ="+ ogretmen1.SinifOrt(ogrenciler));
            Console.Read();
        }

        class Kisi
        {
            
            private string isim;
            private int yas;

            public string ISIM
            {
                get { return isim; }
                set { isim = value; }
            }

            public int YAS
            {
                get { return yas; }
                set { yas = value; }
            }

            public Kisi(string isim, int yas)
            {
                ISIM = isim;
                YAS = yas;
                
            }
        }

        class Ogretmen : Kisi
        {
            public Ogretmen(string isim, int yas) : base(isim, yas)
            {
                
            }

            public void KendiniTanit()
            {
                Console.WriteLine(ISIM + " " + YAS + " yaşında bir öğretmendir.");
            }

            public double SinifOrt(List<Ogrenci> ogrenciler)
            {
                double toplamOrtalama = 0;
                foreach (var ogrenci in ogrenciler)
                {
                    toplamOrtalama += ogrenci.NotOrt();
                }
                return toplamOrtalama / ogrenciler.Count;
            }


        }

        class Ogrenci : Kisi
        {
            public List<double> Notlar { get; private set; }

            public Ogrenci(string isim, int yas) : base(isim, yas)
            {
                Notlar = new List<double>();
            }

            public void KendiniTanit()
            {
                Console.WriteLine(ISIM + " " + YAS + " yaşında bir öğrencidir. Ortalama: " + NotOrt());
            }

            public void Not(double a)
            {
                Notlar.Add(a);
            }

            public double NotOrt()
            {
                double toplam = 0;
                foreach (double x in Notlar)
                {
                    toplam = toplam + x;
                }
                double ortalama = toplam / Notlar.Count;
                
                return ortalama;

            }
        }

    }
}
