using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MES;

            Console.Write("Entre o mes (por extenso): ");
            MES = Console.ReadLine();

            Console.WriteLine();
            switch (MES)
            {
                case "um": Console.WriteLine("Janeiro"); break;
                case "dois": Console.WriteLine("Fevereiro"); break;
                case "tres": Console.WriteLine("Marco"); break;
                case "quatro": Console.WriteLine("Abril"); break;
                case "cinco": Console.WriteLine("Maio"); break;
                case "seis": Console.WriteLine("Junho"); break;
                case "sete": Console.WriteLine("Julho"); break;
                case "oito": Console.WriteLine("Agosto"); break;
                case "nove": Console.WriteLine("Setembro"); break;
                case "dez": Console.WriteLine("Outubro"); break;
                case "onze": Console.WriteLine("Novembro"); break;
                case "doze": Console.WriteLine("Dezembro"); break;
                default: Console.WriteLine("Mes Invalido!"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
