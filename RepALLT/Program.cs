using System;
using System.Collections.Generic;

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
            x Arv
            x Genersika Klasser
            x "Objektorientering"
            x Inkapsling
            x Polymorfism
            */

            List<int> stuff = new List<int>();

            Queue<int> que = new Queue<int>();

            que.Enqueue(77);
            int next = que.Dequeue();

            int heroHp = 100;
            int heroX = 400;
            int heroY = 600;

            Hero theHero = new Hero();
            Hero anotherHero = theHero;



            StrongHero hulk = new StrongHero();

            hulk.Run();

            hulk.Hp = -60;

            

            

            //anotherHero.hp = 1000;
            //theHero.hp = 900;

            Console.WriteLine(hulk.Hp);
            Console.ReadLine();
        }
    }
}
