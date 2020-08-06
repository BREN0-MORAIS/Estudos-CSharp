using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Secao_06
{
    class Exercicio1
    {
        public List<int> id { get; }
        public List<string> NomeFuncionario = new List<string>();
        public List<double> Salario = new List<double>();
        public void Funcionario()
        {
            Console.WriteLine("ID :");
            id.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nome :");
            NomeFuncionario.Add(Console.ReadLine());
            Console.WriteLine("Salario :");
            Salario.Add(double.Parse(Console.ReadLine()));
        }


        public void Principal()
        {
            Console.WriteLine("Quantidade de Funcionarios");
            int quantidade = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < quantidade; i++)
            {
                Funcionario(); 
            }

            if(id[i] == 256)
            {
                Salario[i] *= 10 / 100;
            }

            Console.WriteLine(Salario[i]);
         
           
        }
    }
}
