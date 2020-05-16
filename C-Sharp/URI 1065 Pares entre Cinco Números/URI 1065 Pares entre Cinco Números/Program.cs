using System;

namespace URI_1065_Pares_entre_Cinco_Números
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, a, b, c, d, e;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            count = 0;
            if (a % 2 == 0)
            {
                count += 1;
            }
            if (b % 2 == 0)
            {
                count += 1;
            }
            if (c % 2 == 0)
            {
                count += 1;
            }
            if (d % 2 == 0)
            {
                count += 1;
            }
            if (e % 2 == 0)
            {
                count += 1;
            }

            Console.WriteLine(count + " valores pares");
        }
    }
}
