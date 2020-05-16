using System;

namespace URI_1021_Notas_e_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            int nCem, nCinquenta, nVinte, nDez, nCinco, nDois, nUm, mCinquenta, mVinteCinco, mDez, mCinco, mUm, resto1, resto2;

            X = double.Parse(Console.ReadLine());
            resto2 = (int)(X * 100 + 0.5);

            nCem = resto2 / 10000;
            resto1 = resto2 % 10000;
            nCinquenta = resto1 / 5000;
            resto2 = resto1 % 5000;
            nVinte = resto2 / 2000;
            resto1 = resto2 % 2000;
            nDez = resto1 / 1000;
            resto2 = resto1 % 1000;
            nCinco = resto2 / 500;
            resto1 = resto2 % 500;
            nDois = resto1 / 200;
            resto2 = resto1 % 200;
            nUm = resto2 / 100;
            resto1 = resto2 % 100;
            mCinquenta = resto1 / 50;
            resto2 = resto1 % 50;
            mVinteCinco = resto2 / 25;
            resto1 = resto2 % 25;
            mDez = resto1 / 10;
            resto2 = resto1 % 10;
            mCinco = resto2 / 5;
            mUm = resto2 % 5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nCem + " nota(s) de R$ 100.00");
            Console.WriteLine(nCinquenta + " nota(s) de R$ 50.00");
            Console.WriteLine(nVinte + " nota(s) de R$ 20.00");
            Console.WriteLine(nDez + " nota(s) de R$ 10.00");
            Console.WriteLine(nCinco + " nota(s) de R$ 5.00");
            Console.WriteLine(nDois + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(nUm + " moeda(s) de R$ 1.00");
            Console.WriteLine(mCinquenta + " moeda(s) de R$ 0.50");
            Console.WriteLine(mVinteCinco + " moeda(s) de R$ 0.25");
            Console.WriteLine(mDez + " moeda(s) de R$ 0.10");
            Console.WriteLine(mCinco + " moeda(s) de R$ 0.05");
            Console.WriteLine(mUm + " moeda(s) de R$ 0.01");

        }
    }
}
