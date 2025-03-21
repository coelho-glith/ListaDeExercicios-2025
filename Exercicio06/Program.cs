using System.Diagnostics.CodeAnalysis;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<decimal> notas = new List<decimal>();

            while (true)
            {

                Console.WriteLine("Digite uma nota: ");
                decimal nota = decimal.Parse(Console.ReadLine());

                nota = 1 / nota;

                notas.Add(nota);

                Console.WriteLine("Deseja adicionar mais uma nota? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta == "n")
                {
                    break;
                }
            }

            decimal media = notas.Count / notas.Sum();

            Console.WriteLine($"A média das notas é: {media}");

        }
    }
}
