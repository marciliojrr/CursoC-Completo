using System.Collections.Generic;
using ComposicaoExercicio1.Entities.Enums;

namespace ComposicaoExercicio1.Entities
{
    internal class Worker
    {
        // AutoProps
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associacao entre duas classes diferentes - Composicao

        // Usamos lista porque um trabalhador pode ter varios contratos. Instanciamos para que nao seja uma lista nula
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // Construtores
        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // Metodos
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
