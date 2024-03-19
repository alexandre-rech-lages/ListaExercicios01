namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada
        //de duas provas realizadas por um aluno

        static void Main(string[] args)
        {
            Console.Write("Informe a nota da primeira prova: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o peso da primeira prova: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota da segunda prova: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o peso da segunda prova: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine("A média ponderada é: " + mediaPonderada);

            Console.ReadLine();
        }
    }
}