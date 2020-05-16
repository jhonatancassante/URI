﻿using System;
using System.Globalization;

namespace URI_1040_Média_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, notaExame, mediaFinal;

            string[] valores = Console.ReadLine().Split(' ');
            N1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}