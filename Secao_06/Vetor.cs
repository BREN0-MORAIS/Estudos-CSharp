using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Secao_06
{
    class Vetor
    {

        public void Vector()
        {
            Console.WriteLine("Insira Uma valor");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}
