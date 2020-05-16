using System;

namespace URI_1099_Soma_de_Ímpares_Consecutivos_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, menor, maior, soma;
            string[] vet;

            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                soma = 0;

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > y)
                {
                    maior = x;
                    menor = y + 1;
                }
                else
                {
                    maior = y;
                    menor = x + 1;
                }

                for (int j = menor; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
