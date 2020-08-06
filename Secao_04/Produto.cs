using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_04
{
    class Produto
    {
        public String Nome = "TV";
        public double Preco = 900;
        public int Quantidade = 0;
         

        public void Entrada()
        {
            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            Preco = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {Nome} , {Quantidade} Unidades Total : R$ {Preco} ");

            Console.WriteLine("\nDigite o Numero de Produtos A ser Adicionado no Estoque: ");
            Quantidade = int.Parse(Console.ReadLine());
            AdicionarProduto(Quantidade);
            ValorTotalEmEstoque(Quantidade, Preco);

            Console.WriteLine($"\nDados do Produto Atualizado: {Nome} , {Quantidade} Unidades Total : R$ {Preco} ");

            Console.WriteLine("\nDigite o Numero de Produtos A ser Removido do Estoque: ");
            Quantidade = int.Parse(Console.ReadLine());
            RemoverProduto(Quantidade);
            ValorTotalEmEstoque(Quantidade, Preco);

            Console.WriteLine($"\nDados do Produto Atualizado: {Nome} , {Quantidade} Unidades Total : R$ {Preco} ");
        }


        public double ValorTotalEmEstoque(int qtd , double preco)
        {
            Preco = qtd * preco;
            return Preco;
        }

        public void AdicionarProduto(int qtd)
        {
            Quantidade += qtd; 
        }

        public void RemoverProduto(int qtd)
        {
          Quantidade -= qtd;
        }
    }
}
