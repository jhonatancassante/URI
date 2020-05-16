using System;

namespace URI_1131_Grenais
{
    class Program
    {
        static void Main(string[] args)
        {
            int novoGrenal, golGremio, vitGremio, golInter, vitInter, empate, count;
            String[] vet;

            novoGrenal = 1;
            vitGremio = 0;
            vitInter = 0;
            empate = 0;
            count = 0;

            while (novoGrenal == 1)
            {
                vet = Console.ReadLine().Split(' ');
                golInter = int.Parse(vet[0]);
                golGremio = int.Parse(vet[1]);

                if (golGremio > golInter)
                {
                    vitGremio += 1;
                }
                else if (golGremio < golInter)
                {
                    vitInter += 1;
                }
                else
                {
                    empate += 1;
                }
                count += 1;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(count + " grenais");
            Console.WriteLine("Inter:" + vitInter);
            Console.WriteLine("Gremio:" + vitGremio);
            Console.WriteLine("Empates:" + empate);
            if (vitInter > vitGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitInter < vitGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
