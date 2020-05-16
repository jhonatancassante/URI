using System;

namespace URI_1134_Tipo_de_Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, alcool, gasolina, diesel;
            x = 0;
            alcool = 0;
            gasolina = 0;
            diesel = 0;

            while(x != 4)
            {
                x = int.Parse(Console.ReadLine());
                switch(x)
                {
                    case 1:
                        alcool += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
