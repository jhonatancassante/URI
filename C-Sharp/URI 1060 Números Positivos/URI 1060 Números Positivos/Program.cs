using System;

namespace URI_1060_Números_Positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            int count;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            e = double.Parse(Console.ReadLine());
            f = double.Parse(Console.ReadLine());

            count = 0;
            if (a > 0)
            {
                count += 1;
            }
            if (b > 0)
            {
                count += 1;
            }
            if (c > 0)
            {
                count += 1;
            }
            if (d > 0)
            {
                count += 1;
            }
            if (e > 0)
            {
                count += 1;
            }
            if (f > 0)
            {
                count += 1;
            }

            Console.WriteLine(count + " valores positivos");

        }
    }
}
