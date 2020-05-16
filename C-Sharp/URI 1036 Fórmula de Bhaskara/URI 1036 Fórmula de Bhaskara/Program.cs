using System;

namespace URI_1036_Fórmula_de_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, x1, x2, delta;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            delta = Math.Pow(B, 2.0) - 4.0 * A * C;

            if(A == 0.0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                x2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

                Console.WriteLine("R1 = " + x1.ToString("F5"));
                Console.WriteLine("R2 = " + x2.ToString("F5"));
            }
        }
    }
}
