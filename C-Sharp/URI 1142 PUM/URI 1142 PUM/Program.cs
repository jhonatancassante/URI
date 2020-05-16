using System;

namespace URI_1142_PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 4)
                    {
                        Console.WriteLine("PUM");
                    }
                    else
                    {
                        Console.Write(j + i * 4 + " ");
                    }
                }
            }
        }
    }
}
