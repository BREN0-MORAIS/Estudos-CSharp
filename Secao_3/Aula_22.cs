using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_3
{
    class Aula_22
    {
        public static void EntradaDados_22()
        {
            String EntradaA = Console.ReadLine();
            String EntradaB = Console.ReadLine();
            String EntradaC = Console.ReadLine();
            String EntradaD = Console.ReadLine();
            Console.WriteLine($"{EntradaA}" +
                $"\n{EntradaB}" +
                $"\n{EntradaC}" +
                $"\n{EntradaD}");

            string s = Console.ReadLine(); // vai esta lendo a linha inteira da estring
            string[] vet = s.Split(' '); // a cada espaço na leitura vai se armazenano em um Vetor

            //ou desta forma string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
        }

    }
}
