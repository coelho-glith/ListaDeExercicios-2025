namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número para ver se é primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int divisor1 = numero / 1;
            int divisor2 = numero / numero;

            if (divisor1 == 1 && divisor2 == 1)
            {
                Console.WriteLine("O número é primo");
            }
            else
            {
                Console.WriteLine("O número não é primo");
            }

        }
    }
}
