namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coloque a quantidade de pães que vendeu:");
            decimal pao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("coloque a quantidade de broas que vendeu:");
            decimal broa = Convert.ToDecimal(Console.ReadLine());

            decimal total = (pao * 0.12m) + (broa * 1.50m);

            Console.WriteLine($"O total de vendas é: {total}");

            decimal lucro = total * 0.1m;

            Console.WriteLine($"deve guardar {lucro} na conta poupança");

        }
    }
}
