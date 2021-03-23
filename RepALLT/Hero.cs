using System;

namespace RepALLT
{
    public class Hero
    {
        public static Random generator = new Random(); //Kan bara anropas via klassen och inte instanser när den är static

        public int hp;
        public int x;
        private int y; //Kan inte kommas åt utanför klassen

        public void Run()
        {
           x++;

           if (y < 0)
           {
               hp = 0;
           }   
        }
    }
}
