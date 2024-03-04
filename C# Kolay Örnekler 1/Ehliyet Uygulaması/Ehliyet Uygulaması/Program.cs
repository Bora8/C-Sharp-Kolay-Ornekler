using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehliyet_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınızı Giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas >= 18) 
            {
                Console.WriteLine("Ehliyet alabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Ehliyet almak için "+ (18-yas) + " yıl daha beklemelisiniz.");
            }
            Console.Read();
        }
    }
}
