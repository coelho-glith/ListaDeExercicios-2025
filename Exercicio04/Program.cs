namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva A temperatura em Celcius: ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double Fahrenheit = (celcius * 1.8) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit è: {Fahrenheit}");

            Console.ReadLine();
        }
    }
}
