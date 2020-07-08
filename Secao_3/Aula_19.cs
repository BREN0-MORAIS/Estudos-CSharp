using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_3
{
    class Aula_19
    { //---------------------------------tipos de dados---------------------------------//
        public static void TiposDeDados()
        {
            //Tipo de Dados inteiro
            byte n1 = 254;
            int n2 = 1000;
            int n3 = 21475555;
            long n4 = 2147555555555L;
            n1++;

            Console.WriteLine("byte " + n1);
            Console.WriteLine("int " + n2);
            Console.WriteLine("Maximo Int " + n3);

            //Tipo Logico
            bool completo = false;
            Console.WriteLine("Valor Booleano " + completo);

            //Tipo caracter
            char letraA = 'A';
            char letra = '\u0041';
            string nome = "Breno";
            Console.WriteLine("Letra  " + letraA);
            Console.WriteLine("Nome " + nome);
            Console.WriteLine("letra unicode " + letra);

            //Tipo  Pontos Flutuantes 
            double doubleA = 4.5;
            float floatA = 4.5f;
            Console.WriteLine("double " + doubleA + " float " + floatA);

            //Convertendo string em Double
            string a = "5";
            string b = "5";
            Console.WriteLine(Convert.ToDouble(a) + Convert.ToDouble(b));

            //Tipo generic - aceita qualquer tipo de dados 
            object Calculo = 2 + 3;
            object objnome = "Breno";

            //concatenação 
            var nome1 = "Breno";
            var saldo = 2.20000000000000000000000000000000000000000;
            Console.WriteLine($"{nome1}");
        }
        public static void Calculo_19()
        {
            double a = 20;
            Console.WriteLine($" Somando: {a += 3} Multiplicando: {a *= 3} Subtraindo: {a -= 3} Dividindo: {a /= 4}");
        }
    }
}
