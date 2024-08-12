using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;

            Console.Write("Entre o valor <A>: ");//1. No console escreva
            A = int.Parse(Console.ReadLine());//2. (A = int.parse) Então analise se A é inteiro
            Console.Write("Entre o valor <B>: ");//1.
            B = int.Parse(Console.ReadLine());//2.

            R = A + B;//3. R é atribuido(=) o valor de A + B 

            Console.WriteLine();//4. Pula linha quando vazio 
            if (R > 10)//5. IF = (Se) EX: Se R for Maior que 10 
                Console.WriteLine("Resultado = {0}", R); 

            Console.WriteLine();//4.
            Console.Write("Tecle <Enter> para encerrar... ");//1
            Console.ReadLine();//4
        }
    }
}
