﻿using System;
using System.Globalization;
using ExercicioComInterface.Entities;
using ExercicioComInterface.Services;

namespace ExercicioComInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.WriteLine("-----------------");
            Console.Write("- Car model: ");
            string model = Console.ReadLine();

            Console.Write("- Pickup (dd/mm/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("- Return (dd/mm/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("\nEnter price per hour: $");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: $");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("\nINVOICE:");
            Console.WriteLine("-------");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
