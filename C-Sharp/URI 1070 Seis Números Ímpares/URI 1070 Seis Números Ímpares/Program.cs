using System;

namespace URI_1070_Seis_Números_Ímpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            y = 0;
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                x += 1;
            }
            else
            {
                x += 2;
            }
            while(y < 6)
            {
                Console.WriteLine(x);
                x += 2;
                y += 1;
            }
        }
    }
}
