using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziyi_Son_Elemandan_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "Birol", "Mehmet", "Aydın", "Bora" };
            for(int i = dizi.Length-1; i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.Read();
        }
    }
}
