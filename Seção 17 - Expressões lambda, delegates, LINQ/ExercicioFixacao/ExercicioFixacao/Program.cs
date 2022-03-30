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
                var employeeInfo = employees.Where(e => e.Salary > salaryInfo).OrderBy(e => e.Email).Select(e => e.Email);
                foreach (string employee in employeeInfo)
                {
                    Console.WriteLine(employee);
                }

                double salaryValues = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.Write($"\nSum of salary of people whose name starts with 'M': ${salaryValues.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
