using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktöriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyelini almak istediğiniz sayıyı seçiniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            
          /*  
            for (int i = 0; i<=sayı;  i++)
            {
                sonuc = sonuc * sayı;
                sayı--;
            }
          */

            for(int i = sayı; i > 1; i--)
            {
                sonuc = sayı * sonuc;
                sayı--;
            }
            Console.Write(sonuc);
            Console.Read();
        }
    }
}
