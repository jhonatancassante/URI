using System;

namespace URI_1006_Média_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
        }
    }
}
