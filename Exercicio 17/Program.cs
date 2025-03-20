namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para letra A: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para letra B: ");
            double b = double.Parse(Console.ReadLine());

            if (a == b)
            {
                double c = a + b;

                Console.WriteLine($"O valor de C é: {c}");
            }
            else
            {
                Console.WriteLine("Os valores de A e B são diferentes");
            }
        }
    }
}
