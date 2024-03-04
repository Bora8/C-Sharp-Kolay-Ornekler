using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kura_Çekimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kura çekimine hoşgeldiniz. Katılımcı sayısını belirtiniz.");
            int sayı = int.Parse(Console.ReadLine());
            List<string> Liste = new List<string>();
            Console.WriteLine("Sırasıyla katılımcıları yazınız.");
            
            for(int i = 0; i<sayı; i++)
            {
                Console.Write((i+1)+".katılımcıyı yazınız=");
                string katılımcı = Console.ReadLine();
                Liste.Add(katılımcı);
            }
            Random random = new Random();
            int j = 1;
            for(int i = 0;i <= sayı;i++)
            {
                Console.WriteLine("Enter ile " + (i+1) + ".kazananı belirleyin");
                Console.ReadKey();
                int kazanan = random.Next(0, Liste.Count);
                Console.WriteLine((i+1) + ".kazanan = " + Liste[kazanan]);
                Liste.Remove(Liste[kazanan]);
               
                
            }
            Console.Read();
        }
    }
}
