namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de um Cilindro

        static void Main(string[] args)
        {       
            double raio, altura;           

            Console.WriteLine("Digite o raio do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume do cilindro é: " + volume);

            Console.ReadLine();
        }
    }
}