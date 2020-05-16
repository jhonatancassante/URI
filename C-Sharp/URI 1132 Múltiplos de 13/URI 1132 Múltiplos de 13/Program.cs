using System;

namespace URI_1132_Múltiplos_de_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, menor, maior, soma;
            soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                menor = y;
                maior = x;
            }
            else
            {
                menor = x;
                maior = y;
            }

            for(int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
