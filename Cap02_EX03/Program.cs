using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL;

            Console.WriteLine("Horas trabalhadas ............: ");
            HT = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor da hora ............: ");
            VH = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor do percentual de desconto .: ");
            PD = float.Parse(Console.ReadLine());

            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;


            Console.WriteLine();
            Console.WriteLine("Salario liquido ............: ");
            Console.WriteLine(SL.ToString("##,##0.00"));

            Console.WriteLine();
            Console.WriteLine("Tecla <Enter> para encerrar... ");
            Console.WriteLine();
        }
    }
}
