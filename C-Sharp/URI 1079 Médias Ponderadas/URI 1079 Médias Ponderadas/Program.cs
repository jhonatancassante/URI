using System;

namespace URI_1079_Médias_Ponderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double p1, p2, p3, media;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                p1 = double.Parse(vet[0]);
                p2 = double.Parse(vet[1]);
                p3 = double.Parse(vet[2]);

                media = (p1 * 2.0 + p2 * 3.0 + p3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}
