using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUMERO;

            Console.Write("Entre um Valor: ");
            NUMERO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (NUMERO >= 20 && NUMERO <= 90)//<- Se NUMERO for Maior que 20 ou igual (&& = e) ou NUMERO for menor que 90 ou igual execute o codigo abaixo
                Console.WriteLine("O valor esta entre 20 e 90");
            else // <- Senão se o valor for menor que 20 ou maior que 90 execute o codigo abaixo 
                Console.WriteLine("O valor nao esta entre 20 e 90");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar...");// Escreva
            Console.ReadLine();
        }
    }
}
