using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para converter a temperatura de
        //graus Fahrenheit para graus Celsius

        static void Main(string[] args)
        {
            #region input de dados
            //variáveis de entrada
            decimal temperaturaFahrenheit;

            //varíaveis de saída
            decimal temperaturaCelsius;

            Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
            temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region processamento
            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
            #endregion

            #region output de dados
            Console.WriteLine("A temperatura em graus Celsius é: " + temperaturaCelsius);

            Console.ReadLine();
            #endregion
        }
    }
}