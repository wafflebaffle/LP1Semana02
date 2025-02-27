using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
           Console.WriteLine("Insere número inteiro: ");
           sbyte n = sbyte.Parse(Console.ReadLine());

           Console.WriteLine(--n);
        
           Console.WriteLine(++n);

        }
    }
}
