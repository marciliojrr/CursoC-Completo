namespace Params
{
    internal class Calculator
    {
        // Solucao com sobrecarga de construtores (bad idea)
        public static int Sum(int n1, int n2)
        { return n1 + n2; }

        public static int Sum(int n1, int n2, int n3)
        { return n1 + n2 + n3; }

        public static int Sum(int n1, int n2, int n3, int n4)
        { return n1 + n2 + n3 + n4; }

        // Solucao com vetor
        public static int Sum2(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // Solucao com PARAMS
        public static int Sum3(params int[] numbers) // recebe uma quantia variaveis de valores
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
