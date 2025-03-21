namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Escreva um número:");
           int numero = int.Parse(Console.ReadLine());

           int valorAtual = 0;
           int proximoValor = 1;
           
           for (int i = 0; i <= numero; i++)
            {

                int soma = valorAtual + proximoValor;
                Console.WriteLine(soma);

                valorAtual = proximoValor;
                proximoValor = soma;
            }
        }
    }
}
