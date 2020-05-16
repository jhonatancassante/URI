using System;

namespace URI_1158_Soma_de_Ímpares_Consecutivos_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int count = 1;
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                soma = 0;

                for (int j = 0; count <= y; j++)
                {
                    if((x + j) % 2 != 0)
                    {
                        soma += (x + j);
                        count++;
                    }
                }
                Console.WriteLine(soma);
            }

        }
    }
}
