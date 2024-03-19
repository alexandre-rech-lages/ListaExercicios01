namespace Exercicio11.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool numeroPrimo = true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0 || numero <= 1)
                {
                    numeroPrimo = false;
                    break;
                }
            }

            if (numeroPrimo)
                Console.WriteLine("O número é primo.");
            else
                Console.WriteLine("O número não é primo.");

            Console.ReadLine();
        }
    }
}