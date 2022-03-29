using System;
using System.Collections.Generic;

namespace RestricoesGenerics.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable // Para que se possa comparar
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can note be empty.");
            }



            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                // if (list[i] > max) // ERRO, pois nada garante que os valores que estao sendo comparados, possam ser comparados
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
