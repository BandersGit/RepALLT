using System;

namespace RepALLT
{
    public class Hero
    {
        public static Random generator = new Random(); //Kan bara anropas via klassen och inte instanser när den är static

        protected int hp;
        protected int x; //Protected kan man ändra i klassen och i subklasser men inte utanför dessa
        protected int y; //Private kan inte kommas åt utanför klassen

        // Med dessa kan man inte ändra på variablerna utanför klassen men fortfarande läsa av dem
        public int Hp    
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
                if (hp < 0)
                {
                    hp = 0;
                }
            }
        }

        public void SetHp(int value)
        {
            hp = value;
            if (hp < 0)
            {
                hp = 0;
            }
        }

        public int GetHp()
        {
            return hp;
        }




        public Hero()
        {
            hp = 100;
            x = 50;
            y = 50;
        }

        public virtual void Run()
        {
           x += 10;

           if (y < 0)
           {
               hp = 0;
           }   
        }
    }
}
