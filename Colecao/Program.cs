using System;
using System.Collections.Generic;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Trabalhando com modelagem";
            string aula = "Trabalhando com modelagem";
            string aulasSets = "Trabalhando Com Conjuntos";


            List<string> aulas = new List<string>();
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulasSets
            //};
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulasSets);


            Imprimir(aulas);

        }


        public static void Imprimir(List<string> aulas)
        {
            //foreach (var aulas in aula)
            //{
            //    Console.WriteLine(aulas);
            //}

            //for(int i = 0; i< aula.Count; i++)
            //{
            //    Console.WriteLine(aula[i]); 
            //}
          

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }

        private static void arrray(string[] aulas)
        {

           // aulas = new string[]
           //{
           //     aulaIntro,
           //     aulaModelando,
           //     aulasSets,
           //     aula
           //};
           // aulas[0] = "trabalhando com Arrays";
           // Imprimir(aulas);

           // Console.WriteLine("aula modelando esta no indice: " + Array.IndexOf(aulas, "Trabalhando com modelagem"));
           // Console.WriteLine("Ultimo inice da aula modelando esta : " + Array.LastIndexOf(aulas, "Trabalhando com modelagem"));

           // //revertendo os indices
           // Array.Reverse(aulas);
           // Imprimir(aulas);
           // for (int i = 0; i < aulas.Length; i++)
           // {
           //     Console.WriteLine("\n" + aulas[i]);
           // }
        }
    }
}
