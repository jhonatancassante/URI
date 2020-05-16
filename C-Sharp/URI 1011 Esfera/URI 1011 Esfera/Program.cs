using System;

namespace URI_1011_Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double Raio, Pi, Volume;

            Pi = 3.14159;

            Raio = double.Parse(Console.ReadLine());

            Volume = (4.0 / 3.0) * Pi * Math.Pow(Raio, 3.0);

            Console.WriteLine("VOLUME = " + Volume.ToString("F3"));

        }
    }
}
