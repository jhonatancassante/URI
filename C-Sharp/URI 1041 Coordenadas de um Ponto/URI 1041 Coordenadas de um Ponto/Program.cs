using System;

namespace URI_1041_Coordenadas_de_um_Ponto
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string coordenada;

            String[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            if (x == 0 && y == 0)
            {
                coordenada = "Origem";
            }
            else if (x == 0)
            {
                coordenada = "Eixo Y";
            }
            else if (y == 0)
            {
                coordenada = "Eixo X";
            }
            else if (x > 0 && y > 0)
            {
                coordenada = "Q1";
            }
            else if (x < 0 && y > 0)
            {
                coordenada = "Q2";
            }
            else if (x < 0 && y < 0)
            {
                coordenada = "Q3";
            }
            else
            {
                coordenada = "Q4";
            }
            Console.WriteLine(coordenada);
        }
    }
}
