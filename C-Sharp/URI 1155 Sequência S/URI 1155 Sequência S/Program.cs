using System;

namespace URI_1155_Sequência_S
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;

            s = 0;

            for (int i = 1; i <= 100; i++)
            {
                s = (double)s + (1.0 / i);
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
