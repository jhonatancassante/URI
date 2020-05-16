using System;

namespace URI_1044_Múltiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            String[] vet;

            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (B % A == 0 || A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
