using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metinin_İçinde_Hangi_Harf_Kaç_Kez_Geçiyor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ana metni giriniz:");
            string anametin = Console.ReadLine();

            for (int i = 0; i < anametin.Length; i++)
            {
                int elemansayısı = 1;

                if (anametin.Substring(0, i).Contains(anametin[i].ToString()) == false)
                {
                    for (int j = i + 1; j < anametin.Length; j++)
                    {
                        if (anametin[j] == anametin[i])
                        {
                            elemansayısı++;
                        }
                    }

                    Console.WriteLine(anametin[i] + ":" + elemansayısı);
                }
            }

            Console.Read();

        }
    }
}
