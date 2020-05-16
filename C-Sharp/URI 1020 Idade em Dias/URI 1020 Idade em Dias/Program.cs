using System;

namespace URI_1020_Idade_em_Dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, anos, meses, dias, resto1;

            X = int.Parse(Console.ReadLine());

            anos = X / 365;
            resto1 = X % 365;
            meses = resto1 / 30;
            dias = resto1 % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
