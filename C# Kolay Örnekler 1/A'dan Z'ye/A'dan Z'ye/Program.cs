using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_dan_Z_ye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char c = 'A'; c <= 'Z'; c++) 
            {
                Console.Write(c);
            }
            Console.Read();
        }
    }
}
