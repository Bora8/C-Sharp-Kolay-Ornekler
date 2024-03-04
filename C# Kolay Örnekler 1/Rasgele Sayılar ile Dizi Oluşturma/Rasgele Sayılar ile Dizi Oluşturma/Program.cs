using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasgele_Sayılar_ile_Dizi_Oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Dizinin eleman sayısını belirtiniz");
            int eleman = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[eleman];
            Random random = new Random();
            for (int i = 0; i < eleman; i++)
            {
                A[i] = random.Next(0,200);
            }
            for (int i = 0;i < eleman; i++)
            {
                Console.WriteLine("A[{0}] değeri = "+A[i],i);
            }
            Console.Read();
        }
    }
}
