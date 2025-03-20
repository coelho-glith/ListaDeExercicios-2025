namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o seu nome aqui:");
            string nome = Console.ReadLine();

            Console.WriteLine("Coloque a sua idade aqui:");
            int idade = Convert.ToInt32(Console.ReadLine());

            int Calculo = idade * 365;

            Console.WriteLine($"{nome}, você já viveu {Calculo} dias");

        }
    }
}
