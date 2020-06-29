using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao_3
{
    public static class Aulas
    {
        //---------------------------------tipos de dados---------------------------------//
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
        //---------------------------------cating Conversão---------------------------------//
        public static void Casting_20()
        {
            double c = 3.1;
            int convercaoCast = (int) c; //tranformando double c em inteiro, esta dizendo pode adicionar um 
                                     //double no inteiro porem este double sera convertido para inteiro
            Console.WriteLine(convercaoCast);
        }

        //---------------------------------Valores Aritiméticos---------------------------------//

        public static void Aritmeticos_20()
        {
            int n1= 10;
            int n2 = 15;
     
            double Exponenciacao = Math.Pow(2, 3); //exponenciação , o primeiro parametro é a base e o segundo é o expoente
            double soma = n1 + n2; //somando dois valores 
            double subtrair = n1 - n2; //subtraindo dois valores
            double dividir = n1 / n2; //dividindo dois valores 
            double multiplicar = n1 * n2; //multiplicando dois valores
            Console.WriteLine($"\n Dados N1 é {n1} N2 é {n2}\n" +
                $"Soma: {soma} Subtrair: {subtrair} Dividir: {dividir} Multiplicar: {multiplicar}");

        }
        public static void Aritmeticos_21()
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8; 
            Console.WriteLine(n4);
        }

        public static void EntradaDados_22()
        {
          /*  String EntradaA = Console.ReadLine();
            String EntradaB = Console.ReadLine();
            String EntradaC = Console.ReadLine();
            String EntradaD = Console.ReadLine();
            Console.WriteLine($"{EntradaA}" +
                $"\n{EntradaB}" +
                $"\n{EntradaC}" +
                $"\n{EntradaD}");*/

            string s = Console.ReadLine(); // vai esta lendo a linha inteira da estring
            string[] vet = s.Split(' '); // a cada espaço na leitura vai se armazenano em um Vetor

            //ou desta forma string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);

        }

        public static void EntradaDados_23()
        {
            //iniciar-aula
        }

    }
}
