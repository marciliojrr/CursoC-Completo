namespace ModRefOut
{
    internal class Calculator
    {
        public static void Triple(int x) // Nao funciona, pois altera so o valor da variavel x, e nao de a (usada no prog. principal).
        {
            x = x * 3;
        }

        // Usando o modificador ref
        public static void Triple2(ref int x) // ref e' um modificador de parametro
        {
            x = x * 3;
        }

        // Usando o modificador out
        public static void Triple3(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
