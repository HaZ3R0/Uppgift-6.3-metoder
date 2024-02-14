using System;
namespace halloj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ");
            Console.WriteLine("1. addera tre tal");
            Console.WriteLine("2. välj största talet");
            Console.WriteLine("3. avsluta programmet");
            int val = int.Parse(Console.ReadLine());

            switch(val)
            {

                case 1:
                    Console.WriteLine("Skriv in tre tal");
                    int tal1 = int.Parse(Console.ReadLine());
                    int tal2 = int.Parse(Console.ReadLine());
                    int tal3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("summan av talen blir " + Addera(tal1, tal2, tal3));

                    break;
                
                case 2:
                    Console.WriteLine("Skriv in två tal");
                    int tal11 = int.Parse(Console.ReadLine());
                    int tal22 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Största talet var " + Störst(tal11, tal22));
                    break;

                case 3:
                    break;
            }

            static int Störst(int tal1, int tal2)
            {
                if (tal1 >= tal2)
                {
                    return tal1;
                }
                else
                {
                    return tal2;
                }
            }

            static int Addera(int tal1, int tal2, int tal3)
            {
                return tal1 + tal2 + tal3;
            }
        }
    }
}