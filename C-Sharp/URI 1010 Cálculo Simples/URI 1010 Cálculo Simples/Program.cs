using System;

namespace URI_1010_Cálculo_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodigoPeca1, CodigoPeca2, NumeroPeca1, NumeroPeca2;
            double ValorUnitario1, ValorUnitario2, ValorPagar;

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            CodigoPeca1 = int.Parse(vet1[0]);
            NumeroPeca1 = int.Parse(vet1[1]);
            ValorUnitario1 = double.Parse(vet1[2]);
            CodigoPeca2 = int.Parse(vet2[0]);
            NumeroPeca2 = int.Parse(vet2[1]);
            ValorUnitario2 = double.Parse(vet2[2]);

            ValorPagar = (NumeroPeca1 * ValorUnitario1) + (NumeroPeca2 * ValorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorPagar.ToString("F2"));

        }
    }
}
