using System;

namespace URI_1154_Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, count, soma;
            double media;
            idade = 0;
            count = 0;
            soma = 0;
            media = 0.0;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma += idade;
                count += 1;
                idade = int.Parse(Console.ReadLine());
            }
            media = (double)soma / count;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
