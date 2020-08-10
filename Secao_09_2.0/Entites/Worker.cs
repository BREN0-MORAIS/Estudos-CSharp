using Secao_09_2._0.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Secao_09_2._0.Entites.Enums;

namespace Secao_09_2._0.Entites
{
    //a classe não pode ter Public aao chamr o enum
    class Worker
    {
        public string Name { get; set; }
        public WorkerLavel Lavel { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }
        public Worker(string name, WorkerLavel lavel, double baseSalary, Department department, List<HourContract> contracts)
        {
            Name = name;
            Lavel = lavel;
            BaseSalary = baseSalary;
            Department = department;
            Contracts = contracts;
        }


        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }


        public double income(int year, int month)
        {

            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }

               
            }

            return sum;
        }
    }
}
