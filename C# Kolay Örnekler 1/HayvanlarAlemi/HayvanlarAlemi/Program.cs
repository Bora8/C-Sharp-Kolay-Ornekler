using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemi
{
    /*C# kullanarak, temel Nesne Yönelimli Programlama (NYP) prensiplerini içeren basit bir hayvanlar alemi simülasyonu geliştirin. Bu simülasyon, en azından kapsülleme, kalıtım ve metotların nasıl kullanılacağını göstermelidir. Aşağıdaki gereksinimleri karşılayacak şekilde bir program yazın:

    Kapsülleme(Encapsulation) : Hayvanların isimlerini güvenli bir şekilde saklayın ve bu isimlere yalnızca tanımlı public özellikler(properties) üzerinden erişilebilir olmasını sağlayın.
    Kalıtım(Inheritance): Bir Hayvan temel sınıfı oluşturun ve bu sınıftan türetilen Kedi gibi spesifik hayvan sınıflarıyla kalıtımı gösterin.Her hayvanın ismini (Isim) ve bir ses çıkarma davranışını (SesCikar metodu) içermesini sağlayın.
    Polimorfizm: Hayvan sınıfında tanımlanan SesCikar metotunu, türetilmiş sınıflarda farklı davranışlar sergileyecek şekilde yeniden tanımlayın (override). Örneğin, Kedi sınıfı bu metodu kendi sesiyle("miyav") yanıt verecek şekilde uygulamalıdır.
    Geliştirdiğiniz programda, en az bir Hayvan ve bir Kedi nesnesi oluşturun.Oluşturulan nesneler için SesCikar metodunu çağırın ve konsola hayvanların nasıl farklı sesler çıkardığını gözlemleyin.
    */
    internal class Program
    {
        public abstract class Araba
        {
            public string Marka { get; protected set; }
            public string Model { get; protected set; }
            public int UretimYili { get; protected set; }
            public double Kilometre { get; protected set; }

            protected Araba(string marka, string model, int uretimYili, double kilometre)
            {
                if (string.IsNullOrWhiteSpace(marka) || string.IsNullOrWhiteSpace(model))
                    throw new ArgumentException("Marka ve model boş olamaz.");
                if (uretimYili < 1886) // İlk otomobilin üretim yılı
                    throw new ArgumentException("Üretim yılı 1886'dan küçük olamaz.");
                if (kilometre < 0)
                    throw new ArgumentException("Kilometre negatif olamaz.");

                Marka = marka;
                Model = model;
                UretimYili = uretimYili;
                Kilometre = kilometre;
            }

            public abstract void Calistir();
            public abstract void Durdur();
            public virtual void BilgiGoster()
            {
                Console.WriteLine($"Marka: {Marka}, Model: {Model}, Üretim Yılı: {UretimYili}, Kilometre: {Kilometre}");
            }
        }

        public interface IElektrikliArac
        {
            int SarjSuresi { get; }
            int Menzil { get; }
            void SarjEt();
        }

        public class Sedan : Araba
        {
            public Sedan(string marka, string model, int uretimYili, double kilometre)
                : base(marka, model, uretimYili, kilometre) { }

            public override void Calistir()
            {
                Console.WriteLine($"{Marka} {Model} sedan araç çalıştırıldı.");
            }

            public override void Durdur()
            {
                Console.WriteLine($"{Marka} {Model} sedan araç durduruldu.");
            }
        }

        // Elektrikli araçlar için bir sınıf
        public class ElektrikliArac : Araba, IElektrikliArac
        {
            public int SarjSuresi { get; private set; }
            public int Menzil { get; private set; }

            public ElektrikliArac(string marka, string model, int uretimYili, double kilometre, int sarjSuresi, int menzil)
                : base(marka, model, uretimYili, kilometre)
            {
                if (sarjSuresi <= 0 || menzil <= 0)
                    throw new ArgumentException("Şarj süresi ve menzil pozitif olmalıdır.");

                SarjSuresi = sarjSuresi;
                Menzil = menzil;
            }

            public void SarjEt()
            {
                Console.WriteLine($"{Marka} {Model} şarj ediliyor. Şarj süresi: {SarjSuresi} saat, Menzil: {Menzil} km.");
            }

            public override void Calistir()
            {
                Console.WriteLine($"{Marka} {Model} elektrikli araç çalıştırıldı.");
            }

            public override void Durdur()
            {
                Console.WriteLine($"{Marka} {Model} elektrikli araç durduruldu.");
            }

            public override void BilgiGoster()
            {
                base.BilgiGoster();
                Console.WriteLine($"Şarj Süresi: {SarjSuresi}, Menzil: {Menzil}");
            }
        }

        // Araç koleksiyonunu yöneten sınıf
        public class ArabaYonetimi
        {
            private List<Araba> araclar = new List<Araba>();

            public void ArabaEkle(Araba araba)
            {
                if (araba == null)
                    throw new ArgumentNullException(nameof(araba), "Araba nesnesi null olamaz.");
                araclar.Add(araba);
            }

            public void ArabaSil(Araba araba)
            {
                if (araba == null)
                    throw new ArgumentNullException(nameof(araba), "Araba nesnesi null olamaz.");
                araclar.Remove(araba);
            }

            public void ArabalariListele()
            {
                foreach (var araba in araclar)
                {
                    araba.BilgiGoster();
                }
            }
        }
    }
}
