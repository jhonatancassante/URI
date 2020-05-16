using System;

namespace URI_1078_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,multi;

            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                multi = N * i;
                Console.WriteLine(i + " x " + N + " = " + multi);
            }
        }
    }
}
