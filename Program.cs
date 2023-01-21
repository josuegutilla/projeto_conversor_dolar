using System.Globalization;

namespace ex_dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine());

            double conversor = ConversorMoeda.ConersorDolarReal(dolar, quant);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = " + conversor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
