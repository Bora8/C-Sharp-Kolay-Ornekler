using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_elemanlarını_yüzde_x_arttırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine((i+1)+". elemanı giriniz");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elemanlarınızın % kaç arttırılmış halini görmek istersiniz(Örn: 5, 12, 13..)");
            int x = Convert.ToInt32(Console.ReadLine());
            float ek = 0;
            Console.WriteLine("Sayılarınızın %" + x + " arttırılmış halleri: ");

            for (int i = 0;i < A.Length; i++)
            {
                ek = A[i]*((float)x/100);
                Console.WriteLine(A[i] + ek);
            }
            Console.Read();
        }
    }
}
