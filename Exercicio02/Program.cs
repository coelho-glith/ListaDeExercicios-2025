namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva o raio do cilindro");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ensira a altura do cilindro");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindro é: {volume} cm3 ");

            Console.ReadLine();
            
        }
    }
}
