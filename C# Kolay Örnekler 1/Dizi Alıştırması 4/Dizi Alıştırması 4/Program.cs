using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Alıştırması_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine(i/2);
            }
            else { Console.WriteLine(i*2); }
            Console.Read();
        }
        
    }
}
