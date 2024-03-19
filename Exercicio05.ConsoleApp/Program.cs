namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma esfera

        static void Main(string[] args)
        {            
            double raio, volume;

            Console.WriteLine("Digite o raio da esfera: ");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine("O volume da esfera é: " + volume);

            Console.ReadLine(); 
        }
    }
}