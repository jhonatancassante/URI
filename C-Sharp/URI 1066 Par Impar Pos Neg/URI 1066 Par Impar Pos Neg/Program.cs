using System;

namespace URI_1066_Par_Impar_Pos_Neg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, par, impar, positivo, negativo;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            par = 0;
            impar = 0;
            positivo = 0;
            negativo = 0;

            if (a > 0)
            {
                positivo += 1;
            }
            else if (a < 0)
            {
                negativo += 1;
            }
            if (a % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (b > 0)
            {
                positivo += 1;
            }
            else if (b < 0)
            {
                negativo += 1;
            }
            if (b % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (c > 0)
            {
                positivo += 1;
            }
            else if (c < 0)
            {
                negativo += 1;
            }
            if (c % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (d > 0)
            {
                positivo += 1;
            }
            else if (d < 0)
            {
                negativo += 1;
            }
            if (d % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (e > 0)
            {
                positivo += 1;
            }
            else if (e < 0)
            {
                negativo += 1;
            }
            if (e % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}
