using System;

namespace URI_1065_Número_Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, count;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                count = 0;
                x = int.Parse(Console.ReadLine());
                if (x == 1 || x == 2)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    for (int j = 2; j < x && count == 0; j++)
                    {
                        if (x % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine(x + " eh primo");
                    }
                    else
                    {
                        Console.WriteLine(x + " nao eh primo");
                    }
                }
            }
        }
    }
}
