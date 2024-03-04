using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_kelime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz..");
            string kelime1 = Console.ReadLine();
            int a = 0;
            string kelime = kelime1.Replace(" ", "").ToUpper();
            for (int i = 0; i < kelime.Length / 2; i++)
            {
                if (kelime[i] == kelime[kelime.Length - i - 1])
                {
                    a++;
                }
            }
            if(a == kelime.Length / 2)
            {
                Console.WriteLine("Kelimeniz palindrom kelimedir.");
                for(int i = 0;i<5;i++)
                {
                    Console.WriteLine(kelime1);
                }
            }
            else
            {
                Console.WriteLine("Kelime palindrom kelime değildir.");
            }
            Console.Read();

/*
            Console.WriteLine("Bir kelime giriniz..");
            string kelime1 = Console.ReadLine();
            int a = 0;
            string kelime = kelime1.Replace(" ", "").ToUpper();
            for(int i = 0; i < kelime.Length / 2; i++)
            {
                if(kelime.Substring(i, 1) == kelime.Substring(kelime.Length-i-1,1))
                {
                    a++;
                }
            }
            if(a == kelime.Length / 2)
            {
                Console.WriteLine("Kelimeniz palindrom kelimedir.");
                for(int i = 0;i<5;i++)
                {
                    Console.WriteLine(kelime1);
                }
            }
            else
            {
                Console.WriteLine("Kelime palindrom kelime değildir.");
            }
            Console.Read();
        */    
        }
    }
}
