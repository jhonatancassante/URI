using System;

namespace URI_1047_Tempo_de_Jogo_com_Minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int hInicio, hFim, mInicio, mFim, X, Y, tInicio, tFim, tempo, resto;

            String[] vet = Console.ReadLine().Split(' ');
            hInicio = int.Parse(vet[0]);
            mInicio = int.Parse(vet[1]);
            hFim = int.Parse(vet[2]);
            mFim = int.Parse(vet[3]);

            tInicio = hInicio * 60 + mInicio;
            tFim = hFim * 60 + mFim;

            if (tFim <= tInicio)
            {
                tFim += 24 * 60;
            }

            tempo = tFim - tInicio;

            X = tempo / 60;
            Y = tempo % 60;

            Console.WriteLine("O JOGO DUROU " + X + " HORA(S) E " + Y + " MINUTO(S)");
        }
    }
}
