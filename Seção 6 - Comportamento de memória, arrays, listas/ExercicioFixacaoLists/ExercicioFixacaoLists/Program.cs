using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int nEmployees = int.Parse(Console.ReadLine());
            Console.Write("\n");

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < nEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
                Console.Write("\n");
            }

            Console.Write("Enter de employee Id that will have salary increase or press 0 to cancel: ");
            int idToRaise = int.Parse(Console.ReadLine());
            Employee aux = employees.Find(e => e.Id == idToRaise);

            if (aux != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aux.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This Id does not exist!");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"\n{employee}");
            }
        }
    }
}
