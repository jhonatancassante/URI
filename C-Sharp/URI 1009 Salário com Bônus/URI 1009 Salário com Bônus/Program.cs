using System;

namespace URI_1009_Salário_com_Bônus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double SalarioFixo, TotalVendas, TOTAL;

            nome = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine());
            TotalVendas = double.Parse(Console.ReadLine());

            TOTAL = SalarioFixo + (TotalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2"));
        }
    }
}
