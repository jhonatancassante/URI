using System;

namespace URI_1048_Aumento_de_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioInicial, reajuste, novoSalario, percentual;

            salarioInicial = double.Parse(Console.ReadLine());

            if (salarioInicial >= 0.0 && salarioInicial <= 400.0) percentual = 0.15;
            else if (salarioInicial >= 400.01 && salarioInicial <= 800.0) percentual = 0.12;
            else if (salarioInicial >= 800.01 && salarioInicial <= 1200.0) percentual = 0.10;
            else if (salarioInicial >= 1200.01 && salarioInicial <= 2000.0) percentual = 0.07;
            else percentual = 0.04;

            reajuste = salarioInicial * percentual;
            novoSalario = salarioInicial + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"));
            Console.WriteLine("Em percentual: " + (int)(percentual * 100) + " %");
        }
    }
}
