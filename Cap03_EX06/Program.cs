using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, X;

            Console.Write("Entre o Valor <A>: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Entre o Valor <B>: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Entre o Valor <C>: ");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (!(C > 5))//
                X = (A + B) * C;
            else
                X = (A - B) * C;

            Console.WriteLine("O resultado de X equivale a: " + X);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
