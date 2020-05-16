using System;

namespace URI_1080_Maior_e_Posição
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, pos, maior;
            maior = 0;
            pos = 0;

            for (int i = 1; i <= 100; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    pos = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }
    }
}
