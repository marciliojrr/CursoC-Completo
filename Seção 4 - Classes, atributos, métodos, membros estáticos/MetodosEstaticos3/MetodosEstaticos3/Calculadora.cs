using System;
using System.Globalization;

namespace MetodosEstaticos2
{
    class Calculadora
    {
        public static double Pi = 3.14; //incluir o static permite chamar sem ter que criar um obj

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(r, 3.0);
        }
    }
}
