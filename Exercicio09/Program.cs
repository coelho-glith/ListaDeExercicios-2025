namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o comprimento do terreno: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a largura do terreno: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            decimal area = Convert.ToDecimal(comprimento * largura);

            Console.WriteLine($"A área do terreno é {area}");

        }
    }
}
