using System;
using System.Globalization;

namespace Secao_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Rental data");
            Console.WriteLine("Car Model");
            string model = Console.ReadLine();
            Console.WriteLine("Pickyp (DDD/MMM/YYY hh:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyy",CultureInfo.InvariantCulture);
            Console.WriteLine(start);
        }
    }
}
