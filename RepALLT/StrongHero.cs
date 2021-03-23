using System;

namespace RepALLT
{
    public class StrongHero : Hero
    {
        public StrongHero()
        {
            hp = 1000;
            
        }

        public override void Run() //Samma metod som i basklassen men overridad att ha andra värden på x
        {
            x += 3;
        }
    }
}
