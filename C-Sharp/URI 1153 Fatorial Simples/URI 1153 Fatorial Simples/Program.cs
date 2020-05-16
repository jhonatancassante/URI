using System;

namespace URI_1153_Fatorial_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n = n * i;
            }
            Console.WriteLine(n);
        }
    }
}
