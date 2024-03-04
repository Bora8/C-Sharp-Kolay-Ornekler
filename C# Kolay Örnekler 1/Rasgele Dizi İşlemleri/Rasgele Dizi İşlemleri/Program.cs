using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Rasgele_Dizi_İşlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20]; 
            Random random = new Random();
            int toplam = 0; int ortüstü = 0; int ortaltı = 0;
            float ortalama = 0;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToInt32(random.Next(-2147483648, 2147483647));
                toplam = toplam + A[i];
            }
            ortalama = toplam / 20;
            for (int i = 0;i < A.Length; i++)
            {
                if (A[i] > ortalama)
                {
                    ortüstü++;
                }
                else if (A[i] < ortalama)
                {
                    ortaltı++;
                }
            }
            
            Console.WriteLine(A);
            Console.WriteLine(ortalama);
            Console.WriteLine(ortüstü);
            Console.WriteLine(ortaltı);
            Console.Read();

        }
    }
}
