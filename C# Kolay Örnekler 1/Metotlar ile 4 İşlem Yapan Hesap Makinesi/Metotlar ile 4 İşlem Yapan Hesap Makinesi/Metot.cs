using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_ile_4_İşlem_Yapan_Hesap_Makinesi
{
    internal class Metot
    {     
        public int toplama(int s1, int s2) 
        {
            int sonuc = s1+s2;
            Console.WriteLine(s1 + "+" + s2 + "=" + sonuc);
            return sonuc;
        }

        public int cikarma(int s1, int s2)
        {
            int sonuc = s1-s2;
            Console.WriteLine(s1+"-"+s2+"="+sonuc);
            return sonuc;
        }   
        public int carpma(int s1, int s2)
        {
            int sonuc = s1*s2;
            Console.WriteLine(s1 + "*" + s2 + "=" + sonuc);
            return sonuc;
        }
        public double bolme(double s1, double s2)
        {
            double sonuc = s1/s2;
            Console.WriteLine(s1 + "/" + s2 + "=" + sonuc);
            return sonuc;
        }

    }
}
