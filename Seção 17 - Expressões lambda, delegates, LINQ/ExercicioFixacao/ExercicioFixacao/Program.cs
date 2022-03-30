using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacao.Entities;

namespace ExercicioFixacao
{
    internal class Program
    {
        // Funcao auxiliar
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] data = sr.ReadLine().Split(',');
                        string name = data[0];
                        string email = data[1];
                        double salary = double.Parse(data[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                Console.Write("\nEnter salary: $");

                double salaryInfo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                var employeeInfo = employees.Where(e => e.Salary > salaryInfo).OrderBy(e => e.Name).Select(e => e.Email);
                Print($"Email of people whose salary is more than {salaryInfo}:", employeeInfo);

                double salaryValues = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.Write($"Sum of salary of people whose name starts with 'M': $, {salaryValues}");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
