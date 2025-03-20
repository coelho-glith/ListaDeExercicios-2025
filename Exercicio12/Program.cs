namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o seu salário aqui: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            decimal aumento = salario * 0.15m;
            decimal impostos = salario * 0.08m;
            decimal salarioFinal = salario + aumento - impostos;

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"O seu salário inicial é: {salario}");
            Console.WriteLine($"O seu salário com aumento é: {salario + aumento}");
            Console.WriteLine($"O seu salário final é: {salarioFinal}");
            Console.WriteLine("-----------------------------");

        }
    }
}
