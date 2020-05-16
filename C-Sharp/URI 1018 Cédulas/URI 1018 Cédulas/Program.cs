using System;

namespace URI_1018_Cédulas
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N, cem, cinquenta, vinte, dez, cinco, dois, um, resto1, resto2;

            N = uint.Parse(Console.ReadLine());

            cem = N / 100;
            resto1 = N % 100;
            cinquenta = resto1 / 50;
            resto2 = resto1 % 50;
            vinte = resto2 / 20;
            resto1 = resto2 % 20;
            dez = resto1 / 10;
            resto2 = resto1 % 10;
            cinco = resto2 / 5;
            resto1 = resto2 % 5;
            dois = resto1 / 2;
            um = resto1 % 2;

            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");
        }
    }
}
