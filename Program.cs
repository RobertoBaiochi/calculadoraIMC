using System.Globalization;

namespace AplicativoIMC
{
    internal class Program
    {
        struct Pessoa
        {
            public double altura, peso;
        }

        static void Main(string[] args)
        {

            double imc;

            Console.Write("Digite sua altura: ");
            double alturaEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite seu peso: ");
            double pesoEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Pessoa pessoa = new Pessoa()
            {
                altura = alturaEntrada,
                peso = pesoEntrada,

            };

            imc = CalcularIMC(pessoa.altura, pessoa.peso);

            if (imc < 16)
            {
                Console.WriteLine("Subpeso Severo");
            }
            else if(imc <= 19.9)
            {
                Console.WriteLine("Subpeso");
            }
            else if(imc <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if(imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if(imc <= 39.9)
            {
                Console.WriteLine("Obeso");
            }
            else
            {
                Console.WriteLine("Obeso Mórbido");
            }

        }

        static double CalcularIMC(double altura, double peso)
        {
            return peso / Math.Pow(altura, 2);
        }
    }
}
