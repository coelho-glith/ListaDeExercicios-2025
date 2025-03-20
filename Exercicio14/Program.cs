namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] decrescente = new int[3];

            for (int i = 0; i <= 2; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                decrescente[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(decrescente);
            Array.Reverse(decrescente);            

            Console.WriteLine($"Os números em ordem decrescente é: {string.Join(", ", decrescente)}");

        }
    }
}
