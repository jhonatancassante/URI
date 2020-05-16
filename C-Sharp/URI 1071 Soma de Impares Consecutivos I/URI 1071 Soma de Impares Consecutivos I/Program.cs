using System;

namespace URI_1071_Soma_de_Impares_Consecutivos_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, x2, y2, soma;

            soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                x2 = x+1;
                y2 = y;
            }
            else
            {
                x2 = y+1;
                y2 = x;
            }

            for (int i = x2; i < y2; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
