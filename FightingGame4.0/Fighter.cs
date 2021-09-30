using System;

namespace FightingGame4._0
{
    public class Fighter
    {
        public string name;
        public int hpMax;
        public int hp;
        Weapon weapon;

        Random rand = new Random();
        int resultDamage;


        public Fighter(string nam, int health, Weapon weap)
        {
            name = nam;
            hpMax = health;
            weapon = weap;
            hp = hpMax;
        }

        public void Attack(Fighter target)
        {
            resultDamage = (rand.Next(8, 13) * weapon.attack) / 10;
            Utilities.WriteNice($"{name} strikes {target.name}!");
            Utilities.WriteNice($"{resultDamage} damage!");
            target.hp -= resultDamage;
        }

        public void PrintStats()
        {
            int hpMaxVis = 40;
            float hpVis = ((float)hp / (float)hpMax) * (float)hpMaxVis;
            Console.WriteLine(hpMaxVis);
            Console.WriteLine(hpVis);

            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < (int)hpVis; i++)
            {
                Console.Write("█");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < hpMaxVis - (int)hpVis; i++)
            {
                Console.Write("█");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public bool IsAlive()
        {
            if (hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}