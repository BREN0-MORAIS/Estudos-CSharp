using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao_14.Entites
{
    class Invoice
    {
        public double BasicPayant { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayant, double tax)
        {
            BasicPayant = basicPayant;
            Tax = tax;
        }


        public double TotalPaymant
        {
            get{
                return BasicPayant + Tax;
            }
        }

        public override string ToString()
        {
            return "BasicPaymnt " + 
                BasicPayant.ToString("F2", CultureInfo.InvariantCulture)+
                "\n Tax"+ Tax.ToString("F2",CultureInfo.InvariantCulture)+
                "\n TotalPaymant"+TotalPaymant.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
