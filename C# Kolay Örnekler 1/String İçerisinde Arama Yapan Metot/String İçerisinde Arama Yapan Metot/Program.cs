using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_İçerisinde_Arama_Yapan_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ana metni giriniz:");
            string anametin = Console.ReadLine();
            Console.WriteLine("Ana metin içinde aranacak metni giriniz");
            string arananmetin = Console.ReadLine();
            int elemansayısı = arananmetin.Length;
            int defa = 0;

            for (int i = 0; i <= anametin.Length - arananmetin.Length; i++)
            {
                string substring = anametin.Substring(i, arananmetin.Length);
                if (substring == arananmetin)
                {
                    defa++;
                }
            }
            Console.WriteLine(defa);
            Console.Read();
        }
    }
}
