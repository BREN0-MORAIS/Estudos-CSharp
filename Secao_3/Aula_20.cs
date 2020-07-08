using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_3
{
    class Aula_20
    {

        //---------------------------------cating Conversão---------------------------------//
        public static void Casting_20()
        {
            double c = 3.1;
            /*tranformando double c em inteiro, está dizendo pode adicionar um 
              double no inteiro porem este double sera convertido para inteiro*/
            int convercaoCast = (int)c;
            Console.WriteLine(convercaoCast);
        }

        //---------------------------------Valores Aritiméticos---------------------------------//

        public static void Aritmeticos_20()
        {
            int n1 = 10;
            int n2 = 15;

            double Exponenciacao = Math.Pow(2, 3); //exponenciação , o primeiro parametro é a base e o segundo é o expoente
            double soma = n1 + n2; //somando dois valores 
            double subtrair = n1 - n2; //subtraindo dois valores
            double dividir = n1 / n2; //dividindo dois valores 
            double multiplicar = n1 * n2; //multiplicando dois valores
            Console.WriteLine($"\n Dados N1 é {n1} N2 é {n2}\n" +
                $"Soma: {soma} Subtrair: {subtrair} Dividir: {dividir} Multiplicar: {multiplicar}");

        }

    }
}
