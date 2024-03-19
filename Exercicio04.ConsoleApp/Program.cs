namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o consumo de combustível por Km.
        //Deverá ser informado a quilometragem
        //Inicial e Final do Percurso do Veículo.
        //Deverá ser informado o Consumo de Combustível

        static void Main(string[] args)
        {
            #region input            
            Console.WriteLine("Digite a quilometragem inicial: ");
            double quilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final: ");
            double quilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustível (em litros): ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            #endregion

            #region processamento
            double distanciaPercorrida = quilometragemFinal - quilometragemInicial;

            double consumoPorKm = consumoCombustivel / distanciaPercorrida;
            #endregion

            #region output
            Console.WriteLine("O consumo de combustível por Km é: " + consumoPorKm);

            Console.ReadLine();
            #endregion
        }
    }
}