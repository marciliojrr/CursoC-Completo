using System;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRooms = 10;
            Student[] vect = new Student[numRooms];
            Console.WriteLine($"Number of rooms available: {numRooms}");

            Console.Write("How many rooms will be rented? ");
            int numRent = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 0; i < numRent; i++)
            {
                Console.WriteLine($"Rent #{i + 1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                int room;
                while (true)
                {
                    Console.Write("Room (0 to 9): ");
                    room = int.Parse(Console.ReadLine());

                    if (room < 0 || room > 9)
                    {
                        Console.WriteLine("Please enter a valid room.");
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        break;
                    }
                }
                vect[room] = new Student(name, email, room);
            }
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < numRooms; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
