using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade re = new Recursividade();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Fibonacci: ");
            Console.WriteLine();
            re.GerarSequenciaFibonacci(0, 1, 15);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fatorial: ");
            Console.WriteLine();
            Console.WriteLine(re.GerarFatorial(31));
            Console.WriteLine(re.GerarFatorial(8));
            Console.WriteLine(re.GerarFatorial(5));
            Console.WriteLine(re.GerarFatorial(3));
            Console.ResetColor();
        }
    }
}
