namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é: {imc}");

            if ( imc <= 18.5 )
            {
                Console.WriteLine(imc + " é Abaixo do peso");
            }
            else if ( imc > 18.5 && imc <= 25)
            {
                Console.WriteLine(imc + " é Peso normal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine(imc + " é acima do peso");
            }
            else if (imc > 30)
            {
                Console.WriteLine(imc + " é Obeso");
            }
        }
    }
}
