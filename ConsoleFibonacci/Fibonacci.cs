namespace ConsoleFibonacci
{
    public class Fibonacci
    {
        public static int CalculaSequencia(int tamanho)
        {
            if (tamanho == 0) return 0;
            if (tamanho == 1) return 1;
            return CalculaSequencia(tamanho - 1) + CalculaSequencia(tamanho - 2);
        }
    }
}
