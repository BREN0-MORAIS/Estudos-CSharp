using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao_3
{
    class Aula_23
    {
        public static void EntradaDados_23()
        {
            //Entrada  de dados
            /*pora padrão é um string mas podemos Converter com int.Parse()*/
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double doub = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //saida de dados
            Console.WriteLine("Int: " + n1);
            Console.WriteLine("Char: " + ch);
            Console.WriteLine("Double " + doub.ToString("F2"), CultureInfo.InvariantCulture);

            String[] entradaMaria = Console.ReadLine().Split(' ');
            string nome = entradaMaria[0];
            char sexo = char.Parse(entradaMaria[1]);
            int idade = int.Parse(entradaMaria[2]);
            double altura = double.Parse(entradaMaria[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
