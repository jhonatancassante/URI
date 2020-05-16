using System;

namespace URI_1019_Conversão_de_Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, horas, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            minutos = (N % 3600) / 60;
            segundos = (N % 3600) % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
