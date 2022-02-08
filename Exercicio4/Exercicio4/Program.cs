using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");

            Console.Write("1:");

            string strNum = Console.ReadLine();

            int num = System.Convert.ToInt32(strNum);

            if((num % 2) == 0)
            {
                Console.WriteLine("O numero é par");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("O numero é impar");
                Console.ReadLine();

            }

            

           
        }
    }
}
