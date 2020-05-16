using System;

namespace URI_1150_Ultrapassando_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z, soma, count;

            soma = 0;
            count = 0;

            x = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            
            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            for (int i = x; soma <= z; i++)
            {
                soma += i;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
