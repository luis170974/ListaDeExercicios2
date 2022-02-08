using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");

            Console.WriteLine("Digite os valores");

            Console.Write("A: ");

            string strA = Console.ReadLine();

            Console.Write("B: ");

            string strB = Console.ReadLine();

            int A = System.Convert.ToInt32(strA);

            int B = System.Convert.ToInt32(strB);

            int C = 0;

            if(A == B)
            {
                C = (A + B);
                Console.WriteLine("O resultado é:"+ C);
            }
            else
            {
                C = (A * B);
                Console.WriteLine("O resultado é:"+ C);
            }

        }
    }
}
