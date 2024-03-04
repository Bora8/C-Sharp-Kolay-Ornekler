using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace For_Döngüsü_İle_Üslü_Sayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabanı giriniz:");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üssü giriniz:");
            int üs = Convert.ToInt32(Console.ReadLine());
            int cevap = 1;
            for(int i = 0; i < üs; i++)
            {
                cevap = cevap * taban;
            }
            Console.WriteLine(taban + " üssü " + üs + " = " + cevap);
            Console.Read();
        }
    }
}
