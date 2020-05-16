using System;

namespace URI_1159_Soma_de_Pares_Consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma, somaCount;

            x = int.Parse(Console.ReadLine());

            while(x != 0)
            {
                soma = 0;
                somaCount = 0;
                while (somaCount < 5)
                {
                    if(x % 2 == 0)
                    {
                        soma += x;
                        x += 2;
                        somaCount += 1;
                    }
                    else
                    {
                        x += 1;
                    }
                }
                Console.WriteLine(soma);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
