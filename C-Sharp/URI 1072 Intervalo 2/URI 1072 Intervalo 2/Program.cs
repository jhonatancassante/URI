using System;

namespace URI_1072_Intervalo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, countIn, countOut;

            countIn = 0;
            countOut = 0;

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }
            }
            Console.WriteLine(countIn + " in");
            Console.WriteLine(countOut + " out");
        }
    }
}
