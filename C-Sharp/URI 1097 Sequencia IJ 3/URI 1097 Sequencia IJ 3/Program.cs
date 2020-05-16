using System;

namespace URI_1097_Sequencia_IJ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 6; j >= 4; j--)
                {
                    Console.WriteLine("I=" + i + " J=" + (j+i));
                }
            }
        }
    }
}
