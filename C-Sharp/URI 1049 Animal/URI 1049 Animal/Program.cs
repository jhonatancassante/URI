using System;

namespace URI_1049_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1, a2, a3, animal;

            a1 = Console.ReadLine();
            a2 = Console.ReadLine();
            a3 = Console.ReadLine();

            if (a1 == "vertebrado")
            {
                if (a2 == "ave")
                {
                    if (a3 == "carnivoro")
                    {
                        animal = "aguia";
                    }
                    else
                    {
                        animal = "pomba";
                    }
                }
                else
                {
                    if (a3 == "onivoro")
                    {
                        animal = "homem";
                    }
                    else
                    {
                        animal = "vaca";
                    }
                }
            }
            else
            {
                if (a2 == "inseto")
                {
                    if (a3 == "hematofago")
                    {
                        animal = "pulga";
                    }
                    else
                    {
                        animal = "lagarta";
                    }
                }
                else
                {
                    if (a3 == "hematofago")
                    {
                        animal = "sanguessuga";
                    }
                    else
                    {
                        animal = "minhoca";
                    }
                }
            }

            Console.WriteLine(animal);

        }
    }
}
