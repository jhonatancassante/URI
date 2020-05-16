using System;

namespace URI_1037_Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            string intervalo;

            x = double.Parse(Console.ReadLine());

            if (x >= 0.0 && x <= 25.0)
            {
                intervalo = "Intervalo [0,25]";
            }
            else if (x > 25.0 && x <= 50.0)
            {
                intervalo = "Intervalo (25,50]";
            }
            else if (x > 50.0 && x <= 75.0)
            {
                intervalo = "Intervalo (50,75]";
            }
            else if (x > 75.0 && x <= 100.0)
            {
                intervalo = "Intervalo (75,100]";
            }
            else intervalo = "Fora de intervalo";

            Console.WriteLine(intervalo);
        }
    }
}
