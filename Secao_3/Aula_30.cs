using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_3
{/*-------------------------------------Funções---------------------------------------------*/
    class Aula_30
    {
        public static void MostrarNumeroMaior()
        {
            Console.WriteLine("Digite 3 Numeros");
            Console.WriteLine("n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("n2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("n3");
            int n3 = int.Parse(Console.ReadLine());
            ResultadoMaior(n1,n2,n3);
        }
        static double ResultadoMaior(double a , double b , double c)
        {
            double maior = 0;
            if (a > b && a > c)
            {
                maior = a;

            }
            else if (b > a && b > c)
            {
                maior = b;

            }
            else if (c > a && c > b)
            {
                maior = c;

            } 
            Console.WriteLine($"O maior é {maior}");


            return maior;
        }


    } 
}
