using System;

namespace URI_1038_Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valorunit, valortotal;
            String[] vet;

            vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    valorunit = 4.0;
                    break;
                case 2:
                    valorunit = 4.5;
                    break;
                case 3:
                    valorunit = 5.0;
                    break;
                case 4:
                    valorunit = 2.0;
                    break;
                case 5:
                    valorunit = 1.5;
                    break;
                default:
                    valorunit = 0.0;
                    break;
            }

            valortotal = quantidade * valorunit;

            Console.WriteLine("Total: R$ " + valortotal.ToString("F2"));
        }
    }
}
