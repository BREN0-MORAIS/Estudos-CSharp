using Secao_10.Entites;
using System;

namespace Secao_10
{
    class Program
    {
        static void Main(string[] args)
        {

            BusnessAcount acount = new BusnessAcount(8010,11,100.0,500);


            Console.WriteLine(acount.Balance);
         //   acount.Balance += 20.0;
            Console.Read();
        }
    }
}
