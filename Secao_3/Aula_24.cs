using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_3
{
    class Aula_24
    {
        public static void Comparativos_24()
        {

            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("-------------------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);

        }
    }
}
