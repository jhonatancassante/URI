using System;

namespace URI_1061_Tempo_de_um_Evento
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, w1, w2, x, x1, x2, y, y1, y2, z, z1, z2, inicio, fim, duracao, resto, dia, hora, minuto;

            dia = 24 * 60 * 60;
            hora = 60 * 60;
            minuto = 60;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            w1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            x1 = int.Parse(vet[0]);
            y1 = int.Parse(vet[2]);
            z1 = int.Parse(vet[4]);

            vet = Console.ReadLine().Split(' ');
            w2 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            x2 = int.Parse(vet[0]);
            y2 = int.Parse(vet[2]);
            z2 = int.Parse(vet[4]);

            inicio = w1 * dia + x1 * hora + y1 * minuto + z1;
            fim = w2 * dia + x2 * hora + y2 * minuto + z2;
            duracao = fim - inicio;

            w = duracao / dia;
            resto = duracao % dia;
            x = resto / hora;
            resto = resto % hora;
            y = resto / minuto;
            z = resto % minuto;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");
        }
    }
}
