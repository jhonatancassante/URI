using System;

namespace URI_1101_Sequência_de_Números_e_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, soma, menor, maior;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

            while (m > 0 && n > 0)
            {
                soma = 0;
                if(m > n)
                {
                    maior = m;
                    menor = n;
                }
                else
                {
                    maior = n;
                    menor = m;
                }

                for (int i = menor; i <= maior; i++)
                {
                    soma += i;
                    Console.Write(i + " ");
                }

                Console.WriteLine("Sum=" + soma);

                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
            }
        }
    }
}
