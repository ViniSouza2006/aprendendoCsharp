using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME;

            Console.Write("Entre seu nome");
            NOME = Console.ReadLine();
            Console.Write("Ola, " + NOME);

            Console.WriteLine("");
            Console.WriteLine("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
