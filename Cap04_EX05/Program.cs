﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME1, NOME2, SEXO1, SEXO2;

            Console.Write("Entre o 1o.nome .........: ");
            NOME1 = Console.ReadLine();
            Console.Write("Entre o sexo do 1o nome ..: ");
            SEXO1 = Console.ReadLine();

            Console.Write("Entre o 2o.nome .........: ");
            NOME2 = Console.ReadLine();
            Console.Write("Entre o sexo do 2o.nome ..: ");
            SEXO2 = Console.ReadLine();

            Console.WriteLine();
            if (SEXO1 == "M" ^ SEXO2 == "M")// IF = (se) ^ = (Operador XOR se o Valor 1 for <> de Valor 2 então será verdadeiro senao sera falso)
                Console.WriteLine(NOME1 + " danca com " + NOME2);
            else
                Console.WriteLine(NOME1 + " nao danca com " + NOME2);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
