using System;

namespace URI_1117_Validação_de_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, soma, media;
            int count;

            count = 0;
            soma = 0.0;
            media = 0.0;

            while(count < 2)
            {
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 10)
                {
                    soma += nota;
                    count += 1;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            media = (double)soma / count;
            Console.WriteLine("media = " + media);
        }
    }
}
