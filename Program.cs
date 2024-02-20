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

            Console.WriteLine(Mensagem(imc));

        }

        static double CalcularIMC(double altura, double peso)
        {
            double result = peso / Math.Pow(altura, 2);

            return result;
        }

        static string Mensagem(double imc)
        {
            if (imc < 16)
            {
                return "Subpeso Severo";
            }
            else if (imc <= 19.9)
            {
                return "Subpeso";
            }
            else if (imc <= 24.9)
            {
                return "Normal";
            }
            else if (imc <= 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc <= 39.9)
            {
                return "Obeso";
            }
            else
            {
                return "Obeso Mórbido";
            }
        }
    }
}
