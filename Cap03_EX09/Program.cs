using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MES;//Declara a Variavel Mes como Inteiro
            Console.Write("Entre o mes (numerico): ");//Lê Teclado então 
            MES = int.Parse(Console.ReadLine());//Pula-linha e guarda o valor lido do teclado
            Console.WriteLine();//Pula-linha

            if (MES == 1)//IF = (SE) -[1] Se Variavel MES For identico a um então execute a linha abaixo
                Console.WriteLine("Janeiro");// -[2] Escreve o valor gravado
            else if (MES == 2)// IF ELSE (SENAO SE)
                Console.WriteLine("Fevereiro");// [1]
            else if (MES == 3)// [2]
                Console.WriteLine("Marco");// [1]
            else if (MES == 4)// [2]
                Console.WriteLine("Abril");// [1]
            else if (MES == 5)// [2]
                Console.WriteLine("Maio");// [1]
            else if (MES == 6)// [2]
                Console.WriteLine("Junho");// [1]
            else if (MES == 7)// [2]
                Console.WriteLine("Julho");// [1]
            else if (MES == 8)// [2]
                Console.WriteLine("Agosto");// [1]
            else if (MES == 9)// [2]
                Console.WriteLine("Setembro");// [1]
            else if (MES == 10)// [2]
                Console.WriteLine("Outubro");// [1]
            else if (MES == 11)// [2]
                Console.WriteLine("Novembro");// [1]
            else if (MES == 12)// [2]
                Console.WriteLine("Dezembro");// [1]
            else// ELSE (SENAO)
                Console.WriteLine("Mes Invalido");//Escreve o Valor Guardado
            Console.WriteLine();//Pula-linha
            Console.Write("Tecle <Enter> para encerrar... ");//Escreve Valor Guardado
            Console.ReadLine();//Pula-linha
        }
    }
}
