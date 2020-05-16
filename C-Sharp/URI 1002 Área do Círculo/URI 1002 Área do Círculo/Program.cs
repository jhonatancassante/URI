using System;
using System.Globalization;

namespace URI_1002_Área_do_Círculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, pi, raio;

            pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2.00);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
