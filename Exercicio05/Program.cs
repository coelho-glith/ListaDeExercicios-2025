namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o seu salário base: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escreva o total de vendas: ");
            int totaldeVendas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva a porcentagem de Comissão que você ganha por venda: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine());

            double porcentagemConvertida = porcentagem / 100;

            double salarioTotal = salarioBase + totaldeVendas + (totaldeVendas * porcentagemConvertida);

            Console.Write($"O salário total do vendedor é de {salarioTotal} ");

            Console.ReadLine();
        }
    }
}
