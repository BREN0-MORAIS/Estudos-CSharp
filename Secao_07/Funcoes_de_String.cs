using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_07
{
    public  class Funcoes_de_String
    {
        public static void FuncoesString()
        {
            string a = "abcdef ABCDEF";

            //transforma a String em Maiusculo
            string Maiusculo = a.ToUpper();
            string minusculo = a.ToLower();
            string ApagarEspaço = a.Trim();
            string replace = a.Replace('A', 'B');
            Console.WriteLine(Maiusculo);
            Console.WriteLine(minusculo);
            Console.WriteLine(ApagarEspaço);
            Console.WriteLine(replace);
        }
    }
}
