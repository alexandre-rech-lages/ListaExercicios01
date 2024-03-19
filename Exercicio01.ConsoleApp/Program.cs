namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma caixa retangular
        // V = comprimento x largura x altura
        static void Main(string[] args)
        {
            #region INPUT - entrada de dados

            //variáveis informadas pelo usuário
            decimal comprimento, largura, altura;
            //pra trabalhar com números quebrados quais tipos no c#            
            // decimal precisão de 18 casas decimais            

            Console.Clear();
            Console.WriteLine("Digite o comprimento da caixa: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region PROCESSAMENTO
            decimal volume = comprimento * largura * altura;

            #endregion

            #region OUTPUT - saída de dados
            Console.WriteLine("O volume da caixa é: " + volume);

            Console.ReadLine();
            #endregion
        }
    }
}