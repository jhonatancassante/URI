using System;

namespace URI_1008_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroFuncionario, HorasTrabalhadas;
            double ValorHora, Salario;

            NumeroFuncionario = int.Parse(Console.ReadLine());
            HorasTrabalhadas = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine());

            Salario = HorasTrabalhadas * ValorHora;

            Console.WriteLine("NUMBER = " + NumeroFuncionario);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2"));
        }
    }
}
