using System;

namespace URI_1015_Distância_Entre_Dois_Pontos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, Distancia;

            String[] vet1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet1[0]);
            y1 = double.Parse(vet1[1]);
            String[] vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0]);
            y2 = double.Parse(vet2[1]);

            Distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

            Console.WriteLine(Distancia.ToString("F4"));
        }
    }
}
