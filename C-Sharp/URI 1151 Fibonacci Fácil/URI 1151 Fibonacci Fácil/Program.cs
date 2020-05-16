using System;

namespace URI_1151_Fibonacci_Fácil
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, k, l;
            j = 0;
            k = 1;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i < 2)
                {
                    Console.Write(i + " ");
                }
                else if (i + 1 == n)
                {
                    l = j + k;
                    Console.WriteLine(l);
                }
                else
                {
                    l = j + k;
                    j = k;
                    k = l;
                    Console.Write(l + " ");
                }
            }
        }
    }
}
