using System;

namespace URI_1046_Tempo_de_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicial, final, total;

            String[] vet = Console.ReadLine().Split(' ');
            inicial = int.Parse(vet[0]);
            final = int.Parse(vet[1]);

            if (inicial >= final)
            {
                final += 24;
            }

            total = final - inicial;

            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
        }
    }
}
