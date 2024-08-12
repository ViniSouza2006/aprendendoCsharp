using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;

            Console.Write("Entre o Valor <A>: ");//Escreva o Valor WRITE
            A = int.Parse(Console.ReadLine());//1. PARSE Analise se A é inteiro então LEIA guarde o valor de A
            Console.Write("Entre o Valor <B>: ");
            B = int.Parse(Console.ReadLine());//1.

            R = A + B; //2. R foi atribuido pelo valor de A + B então seu valor passa a ser o valor do A somado a B

            Console.WriteLine();// Quando Vazio Pulalinha
            if (R > 10) //3. Se R for Maior que 10 execute o codigo abaixo 
                Console.WriteLine("Resultado utrapassa dez.");
            else//4. Senão o codigo abaixo foi executado
                Console.WriteLine("Resultado nao ultrapassa dez.");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
