namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem Final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o Consumo de Combustivel: ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = kmFinal - kmInicial;

            double consumoPorkm = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine($"O consumo de combustivel durante o percurso foi de ~ {consumoPorkm} km/l ");

            Console.ReadLine();
        }
    }
}
