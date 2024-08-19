using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i += 2)
                Console.WriteLine("i = {0}", i);
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
