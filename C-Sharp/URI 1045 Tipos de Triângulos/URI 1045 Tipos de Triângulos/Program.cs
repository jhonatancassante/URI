using System;

namespace URI_1045_Tipos_de_Triângulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, A2, B1, B2, C1, C2;

            String[] vet = Console.ReadLine().Split(' ');
            A1 = double.Parse(vet[0]);
            B1 = double.Parse(vet[1]);
            C1 = double.Parse(vet[2]);

            if (A1 >= B1 && A1 >= C1)
            {
                A2 = A1;
                if (B1 >= C1)
                {
                    B2 = B1;
                    C2 = C1;
                }
                else
                {
                    B2 = C1;
                    C2 = B1;
                }
            }
            else if (B1 >= C1)
            {
                A2 = B1;
                if (A1 >= C1)
                {
                    B2 = A1;
                    C2 = C1;
                }
                else
                {
                    B2 = C1;
                    C2 = A1;
                }
            }
            else
            {
                A2 = C1;
                if (A1 >= B1)
                {
                    B2 = A1;
                    C2 = B1;
                }
                else
                {
                    B2 = B1;
                    C2 = A1;
                }
            }
            
            if (A2 >= B2 + C2)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(A2, 2.0) == (Math.Pow(B2, 2.0) + Math.Pow(C2, 2.0)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(A2, 2.0) > (Math.Pow(B2, 2.0) + Math.Pow(C2, 2.0)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A2 == B2 && A2 == C2)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A2 == B2 || A2 == C2 || B2 == C2)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
