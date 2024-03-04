using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Alıştıması_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A= new string[10];

            for (int  i = 0; i <10 ; i++)
            {
                Console.WriteLine((i+1)+". elemanı giriniz:");
                A[i] = Console.ReadLine();
            }
        int elemansayısı = 0; int elemanindexi = 0; string elemaninmetni = ""; int j = 0;
            foreach (string s in A)
            {
                if(s.Length > elemansayısı)
                {
                    elemaninmetni = s;
                    elemansayısı = s.Length;
                    elemanindexi = j;
                }
                j++;
            }
            Console.WriteLine("En uzun metin: "+ elemaninmetni);
            Console.WriteLine("Eleman sayısı: "+ elemansayısı);
            Console.WriteLine("Metinin indexi: "+ elemanindexi);
            Console.Read();
        }
    }
}
