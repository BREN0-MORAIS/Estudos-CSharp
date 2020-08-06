using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_06
{
    class Foreach
    {
       public void  MetodoForeach() { 
            string[] vet = new string[] { "Flutter", "Java", "C#", "Xamarin" };

            //roda em cad indice com o apelido Obje no vetor Vet , imprima os Indices
            foreach (string obje in vet)
            {
                Console.WriteLine(obje);
                Console.WriteLine("--------------------");

            }
        }
    }
}
