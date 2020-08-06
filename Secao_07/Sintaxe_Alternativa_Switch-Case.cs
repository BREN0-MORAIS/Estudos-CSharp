using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Secao_07
{
    public class Sintaxe_Alternativa_Switch_Case
    {
        public static void AlteranativaSqwitch(int x)
        {
      

            switch (x)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;

            }

        }
    }
}
