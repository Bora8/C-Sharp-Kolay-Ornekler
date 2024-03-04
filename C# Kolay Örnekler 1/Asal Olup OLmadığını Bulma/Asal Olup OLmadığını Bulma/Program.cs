using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asal_Olup_OLmadığını_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asallığını test etmek istediğiniz sayıyı giriniz");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int c = 0;
            int d = 0;

            for (int j = 2; j < a; j++)
            {
                if (a % j == 0)
                {
                    b++;
                }
            }

            if (b == 0)
            {
                Console.WriteLine("Girdiğiniz sayı asaldır.");
                
                for (int i = a + 2; i < a + 100000; i++)
                {
                    if (d != 5)
                    {
                        for (int k = 2; k < i; k++)
                        {
                            if (i % k == 0)
                            {
                                c++;
                            }
                        }
                        if (c == 0)
                        {
                            Console.WriteLine(i);
                            d++;
                        }
                        c = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            }
            Console.Read();
        }
    }
}
