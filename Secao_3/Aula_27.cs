using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_3
{
    class Aula_27
    {
        /*---------------------------Condicional--------------------------------*/
        public static void EstruturaCondicional_27()
        {
            Console.WriteLine("Digite um Valor ?");

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else if (x % 2 >= 1)
            {
                Console.WriteLine("Impar");
            }
            else
            {
                Console.WriteLine("dados invalidos");
            }
        }
    }
}
