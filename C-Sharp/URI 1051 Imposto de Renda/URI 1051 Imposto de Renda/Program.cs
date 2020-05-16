using System;

namespace URI_1051_Imposto_de_Renda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto;

            salario = double.Parse(Console.ReadLine());
            
            if (salario > 4500.0)
            {
                imposto = (salario - 4500.0) * 0.28;
                imposto += (4500.0 - 3000.0) * 0.18;
                imposto += (3000.0 - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            }
            else if (salario > 3000.0)
            {
                imposto = (salario - 3000.0) * 0.18;
                imposto += (3000.0 - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            }
            else if (salario > 2000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Isento");
            }
        }
    }
}
