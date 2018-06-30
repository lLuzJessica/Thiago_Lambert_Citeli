using System;
namespace ConsoleFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos elementos deseja: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("{0}", Fibonacci.CalculaSequencia(i));
            }
            Console.ReadLine();
        }
    }
}
