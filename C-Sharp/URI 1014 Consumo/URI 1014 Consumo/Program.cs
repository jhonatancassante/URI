using System;

namespace URI_1014_Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, Total;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            Total = X / Y;

            Console.WriteLine(Total.ToString("F3") + " km/l");
        }
    }
}
