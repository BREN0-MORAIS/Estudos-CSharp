using System.Collections.Generic;
using System;
using System.Globalization;
using System.Text;

namespace Secao_3
{
  public static class Secao_3
    {
        public static void Atividade1()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650;
            double medida = 53.234567;

            Console.WriteLine($"Computador, Cujo o preço é ${preco1}" + //mostrar o valor do preco1
                $"\nMesa de escritório, cujo preço é {preco2}" + //mostra o valor do Preco2
                $"\nRegisto: {idade} anos de idade, código {codigo} e genero: {genero}" + //mostra o genero M
                $"\n\nMedida com oito casas decimais {medida:F8} " + //mostra medida com 8 casas decimais
                $"\n arredondando 3 casas decimais {medida:F3}" + //mostra medida com 3 casas decimais
                $"\n separar decimal invariant culture {medida.ToString(CultureInfo.InvariantCulture)}");//imprime o valor com o ponto
        }
    }
}
