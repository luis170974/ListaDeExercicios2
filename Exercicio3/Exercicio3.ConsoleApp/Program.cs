using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao calculo de IMC");

            Console.WriteLine("Digite seu peso:");

            string strPeso = Console.ReadLine();

            Console.WriteLine("Digite sua altura:");

            string strAltura = Console.ReadLine();

            double Peso = System.Convert.ToDouble(strPeso);
        
            double Altura = System.Convert.ToDouble(strAltura);

            double resultadoIMC = Peso / (Altura*Altura);

            if(resultadoIMC < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
                Console.ReadLine();
                Console.Clear();

            }
            
            else if(resultadoIMC >= 18.5 && resultadoIMC <= 25)
            {
                Console.WriteLine("Peso normal");
                Console.ReadLine();
                Console.Clear();
            }
            
            else if (resultadoIMC >= 25 && resultadoIMC <= 30)
            {
                Console.WriteLine("Acima do Peso");
                Console.ReadLine();
                Console.Clear();
            }
            
            else if(resultadoIMC > 30)
            {
                Console.WriteLine("Obeso");
                Console.ReadLine();
                Console.Clear();
            }

        }

    }
}
