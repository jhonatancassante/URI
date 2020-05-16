using System;

namespace URI_1094_Experiências
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quantia, coelhos, sapos, ratos, totalCobaias;
            char tipo;
            double percentCoelhos, percentSapos, percentRatos;
            string[] vet;

            totalCobaias = 0;
            coelhos = 0;
            sapos = 0;
            ratos = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);
                totalCobaias += quantia;

                if (tipo == 'C')
                {
                    coelhos += quantia;
                }
                else if (tipo == 'S')
                {
                    sapos += quantia;
                }
                else
                {
                    ratos += quantia;
                }
            }

            percentCoelhos = (double)coelhos * 100.00 / totalCobaias;
            percentSapos = (double)sapos * 100.00 / totalCobaias;
            percentRatos = (double)ratos * 100.00 / totalCobaias;

            Console.WriteLine("Total: " + totalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + percentCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + percentRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + percentSapos.ToString("F2") + " %");
        }
    }
}
