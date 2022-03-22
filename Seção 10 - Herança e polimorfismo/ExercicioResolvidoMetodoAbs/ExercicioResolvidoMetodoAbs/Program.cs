using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioResolvidoMetodoAbs.Entities;
using ExercicioResolvidoMetodoAbs.Entities.Enums;

namespace ExercicioResolvidoMetodoAbs
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter the number of shapes: ");
            int numShapes = int.Parse(Console.ReadLine());

            List<Shape> listShapes = new List<Shape>();

            for (int i = 0; i < numShapes; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectange or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShapes.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in listShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
