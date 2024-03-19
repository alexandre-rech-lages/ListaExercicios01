namespace Exercicio08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura da lata de óleo: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o raio da base da lata de óleo: ");
            int raio = Convert.ToInt32(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume da lata de óleo é: " + volume);

            Console.ReadLine();
        }
    }
}