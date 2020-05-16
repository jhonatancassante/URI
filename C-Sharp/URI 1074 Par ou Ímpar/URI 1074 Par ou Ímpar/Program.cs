using System;

namespace URI_1074_Par_ou_Ímpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x;

            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                string mensage1, mensage2;
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        mensage1 = "EVEN";
                    }
                    else
                    {
                        mensage1 = "ODD";
                    }

                    if (x > 0)
                    {
                        mensage2 = "POSITIVE";
                    }
                    else
                    {
                        mensage2 = "NEGATIVE";
                    }
                    Console.WriteLine(mensage1 + " " + mensage2);
                }
            }

        }
    }
}
