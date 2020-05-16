using System;

namespace URI_1156_Sequência_S_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, j;
            s = 1.0;
            j = 2.0;

            for (int i = 3; i <= 39; i += 2)
            {
                s = (double)s + (i / j);
                j = j * 2.0;
            }
            Console.WriteLine(s.ToString("F2"));
        }
    }
}
