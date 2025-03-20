namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Coloque o valor da letra A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque o valor da letra B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque o valor da letra C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A + B é menor que C");
            }
            else
            {
                Console.WriteLine("A + B  que C");
            }

        }
    }
}
