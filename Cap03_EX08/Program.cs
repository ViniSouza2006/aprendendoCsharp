using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float R, A, B;// FLOAT = (Numero impreciso [ "," "." ])
            int OPCAO;// OPCAO Declarada como inteiro
            Console.Write("Informe o 1o. Valor: ");
            A = float.Parse(Console.ReadLine());//FLOAT.PARSE = Converte a Variavel para um numero impreciso
            Console.Write("Informe o 2o. Valor: ");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("[1] ............. Adição");//WriteLine Escreve na linha o valor guardado 
            Console.WriteLine("[2] .......... Subtração");
            Console.WriteLine("[3] ...... Multiplicação");
            Console.WriteLine("[4] ............ Divisão");
            Console.WriteLine();//Pula-linha
            Console.Write("Escolha uma opção --> ");
            OPCAO = int.Parse(Console.ReadLine());//OPCAO e convertida para inteiro 
            if (OPCAO == 1)// SE OPCAO for identico a 1 então Verdadeiro execute a linha abaixo
            {
                R = A + B;// SE VERDADEIRO Então R sera atribuido (" = ") a A + B 
                Console.WriteLine("Resultado = " + R);// ESCREVA Valor guardado e Variavel (R)  
            }
            if (OPCAO == 2)// SE OPCAO for identico a 2 então Verdadeiro execute a linha abaixo
            {
                R = A - B;
                Console.WriteLine("Resultado = " + R);

            }
            if (OPCAO == 3)// SE OPCAO for identico a 3 então Verdadeiro execute a linha abaixo
            {
                R = A * B;
                Console.WriteLine("Resultado = " + R);

            }
            if (OPCAO == 4)// SE OPCAO for identico a 4 executa a linha abaixo 
                if (B == 0)// SE OPCAO for Identico a 0 execute a linha abaixo
                    Console.WriteLine("ERRO - Divisão por Zero!");
            else// SENAO execute a linha abaixo
            {
                    R = A / B;
                    Console.WriteLine("Resultado = " + R);
            }
            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
