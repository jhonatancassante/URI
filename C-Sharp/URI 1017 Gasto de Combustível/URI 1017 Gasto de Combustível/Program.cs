﻿using System;

namespace URI_1017_Gasto_de_Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, distancia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3"));
        }
    }
}
