using System;
using Example2.Entities;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // """"""SOLUCAO RUIM""""""""
            // METODO RETORNANDO STRING ATRAVES DE METODO CRIADO NA CLASSE RESERVATION
            


            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            
            Console.Write("Check-out date (dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date.");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine($"Error in reservation: {error}");
                }
                else
                {
                    Console.WriteLine(reservation);
                }
            }
        }
    }
}