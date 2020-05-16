using System;

namespace URI_1145_Sequência_Lógica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                if (i % x == 0 || i == y)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
