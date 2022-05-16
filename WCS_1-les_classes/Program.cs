using System;

namespace WCS_1_les_classes
{
    public class Character

    {

        public string name;

        public int HP;

        public int ATK;

        public int DEF;


        public bool IsAlive()
        {
            if (this.HP > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Attack(Character target)          
        {
            target.HP = (target.HP) - (this.ATK - target.DEF);
            Console.WriteLine("test");
            if (this.ATK <= target.DEF)
            {
                Console.WriteLine(target.name + " is too tanky for " + this.name);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("It's very effective ! " + target.name + " have now " + target.HP + "HP");
                Console.ReadKey();
            }
        }


    }
    class Fight
    {
        static void Main()
        {
            Character mycat = new Character();
            mycat.name = "Jacob";
            mycat.HP = 10;
            mycat.ATK = 5;
            mycat.DEF = 2;

            Character myself = new Character();
            myself.name = "simple Hooman";
            myself.HP = 10;
            myself.ATK = 0;
            myself.DEF = 3;

            while (mycat.IsAlive() && myself.IsAlive())
            {
                Console.WriteLine("Cat attack scratch");
                mycat.Attack(myself);
                if (myself.IsAlive())
                {
                    Console.WriteLine("Hooman attack splash");
                    myself.Attack(mycat);
                }
            }
            if (!mycat.IsAlive())
            {
                Console.WriteLine("Jacob has 8 lives left. Be ready simple hooman.");
                mycat.HP = 10;
            }
            else if (!myself.IsAlive())
            {
                Console.WriteLine("You died.");
            }
            Console.ReadKey();
        }

    }

}
