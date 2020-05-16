using System;

namespace URI_1143_Quadrado_e_ao_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    int k = (int)Math.Pow(i, j);
                    if (j == 3)
                    {
                        Console.WriteLine(k);
                    }
                    else
                    {
                        Console.Write(k + " ");
                    }
                }
            }
        }
    }
}
