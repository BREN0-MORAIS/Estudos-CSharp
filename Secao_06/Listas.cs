using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_06
{
    class Listas
    {
        public static void Lista()
        {
            List<string> lista = new List<string>();
            /* List<string> lista2 = new List<string> { "Maria","João","Jose","Jonathan"};
             Console.WriteLine(lista2);*/

            lista.Add("Breno");
            lista.Add("João");
            lista.Add("Ana");
            lista.Add("Maria");
            lista.Insert(1, "Anna Maria"); //Consegue  inserir o indice que quer gravar o valor
            lista.Insert(0, "Breno Morais");
            foreach (string list in lista)
            {
                Console.WriteLine(list);
                Console.WriteLine("-----------------");

            }
            Console.WriteLine(lista.Count);//mostra o tamando da lista
            string nome = lista.Find(x => x[0] == 'A'); //encontre o indeice que tenha o valor A utilizando uma expressão lambda 
            Console.WriteLine("Nome que começa com a Letra A: " + nome);

            string finalNome = lista.FindLast(x => x[0] == 'o');
            Console.WriteLine("Nome com Final s é " + finalNome);
            int indiceNome = lista.FindIndex(x => x[0] == 'B');
            Console.WriteLine(indiceNome);


            Console.WriteLine("Removido foi " + lista.Remove("Breno"));

            foreach (string list in lista)
            {
                Console.WriteLine(list);
                Console.WriteLine("-----------------");

            }
            lista.RemoveAll(x => x[0] == 'B');

            Console.WriteLine($"-----------------------Removidos-----------");

            foreach (string list in lista)
            {
                Console.WriteLine(list);
                Console.WriteLine("-----------------");

            }

            /* static bool teste(string s)
             {
                 return s[0] == 'A';
             }*/
        }
    }
}
