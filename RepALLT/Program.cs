using System;

namespace RepALLT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            x Klasser och instanser
            x Metoder i klasser + algoritmer
            x Synlighet (public/private)
            - Arv
            - Genersika Klasser
            - "Objektorientering"
            + Inkapsling
            + Polymorfism
            */

            int heroHp = 100;
            int heroX = 400;
            int heroY = 600;

            Hero theHero = new Hero();
            Hero anotherHero = theHero;
            
            anotherHero.hp = 1000;
            theHero.hp = 900;

            Console.WriteLine(anotherHero.hp);
            Console.ReadLine();
        }
    }
}
