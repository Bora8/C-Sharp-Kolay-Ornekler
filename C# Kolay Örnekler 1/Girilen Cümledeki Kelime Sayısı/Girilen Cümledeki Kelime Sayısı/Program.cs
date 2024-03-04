using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Cümledeki_Kelime_Sayısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen Cümledeki Kelime Sayısı
            string cümle = Console.ReadLine();
            int a = 0;
            for(int i = 0; i < cümle.Length-1; i++)
            {
                if (cümle[i] == ' ')
                {
                    a++;
                }
            }
            int adet = a+1;
            Console.WriteLine("Girilen cümlede "+adet+" tane kelime var");
            Console.Read();
        }
    }
}
