using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Alıştırması_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("A[{0}] değeri=", i);
                A[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(i + ".değer=" + A[i]);
                
            }
            Console.Read();
        }
    }
}
