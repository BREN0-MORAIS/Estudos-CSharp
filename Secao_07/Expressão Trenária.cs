using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_07
{
    public static class Expressão_Trenária
    {
        public static void Ternaria()
        {                  //se 2 for maior que 1 (?) -> Faça 2 (:)se não Faça 1
            double valor = (2 > 1) ? 2 : 1;
            Console.WriteLine(valor);
        }
    }
}
