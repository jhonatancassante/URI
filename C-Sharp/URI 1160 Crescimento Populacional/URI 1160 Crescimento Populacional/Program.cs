using System;

namespace URI_1160_Crescimento_Populacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, pa, pb;
            double g1, g2;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int x, y;
                int anos = 0;
                string[] vet = Console.ReadLine().Split(' ');
                pa = int.Parse(vet[0]);
                pb = int.Parse(vet[1]);
                g1 = double.Parse(vet[2]);
                g2 = double.Parse(vet[3]);

                x = pa;
                y = pb;

                while (x <= y && anos <= 100)
                {
                    x = (int)(x + (x * g1 / 100));
                    y = (int)(y + (y * g2 / 100));

                    anos++;
                }
                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine(anos + " anos.");
                }

            }
        }
    }
}
