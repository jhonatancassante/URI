using System;

namespace URI_1012_Área
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, PI, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            String[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);
            PI = 3.14159;

            TRIANGULO = (A * C) / 2.0;
            CIRCULO = PI * Math.Pow(C, 2.0);
            TRAPEZIO = ((A + B) * C) / 2.0;
            QUADRADO = Math.Pow(B, 2.0);
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3"));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3"));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3"));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3"));

        }
    }
}
