using System;
using System.Collections.Generic;
using ExercicioResolvido.Entities;
using System.Globalization;

namespace ExercicioResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number os employees: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            List<Employee> employeesList = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: $");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: $");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employeesList.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employeesList.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employeesList)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
