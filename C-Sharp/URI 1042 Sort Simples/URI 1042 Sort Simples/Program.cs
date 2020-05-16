using System;

namespace URI_1042_Sort_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, b1, b2, c1, c2;

            String[] vet = Console.ReadLine().Split(' ');

            a1 = int.Parse(vet[0]);
            b1 = int.Parse(vet[1]);
            c1 = int.Parse(vet[2]);

            if (a1 <= b1 && a1 <= c1)
            {
                a2 = a1;

                if (b1 <= c1)
                {
                    b2 = b1;
                    c2 = c1;
                }
                else
                {
                    b2 = c1;
                    c2 = b1;
                }
            }
            else if (b1 <= c1)
            {
                a2 = b1;
                if (a1 <= c1)
                {
                    b2 = a1;
                    c2 = c1;
                }
                else
                {
                    b2 = c1;
                    c2 = a1;
                }
            }
            else
            {
                a2 = c1;
                if (a1 <= b1)
                {
                    b2 = a1;
                    c2 = b1;
                }
                else
                {
                    b2 = b1;
                    c2 = a1;
                }
            }
            Console.WriteLine(a2);
            Console.WriteLine(b2);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine(c1);
        }
    }
}
