using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayısal_Loto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Konsol Sayısını Giriniz..");
            int sayı = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < sayı; i++)
            {
                for (int j = 0; j<6 ; j++)
                {
                    int numara = random.Next(1,60);
                    if (numara >= 0 && numara <=9)
                    {
                        Console.Write("0"+numara + " ");
                    }
                    else
                    {
                        Console.Write(numara + " ");
                    }
                    
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
