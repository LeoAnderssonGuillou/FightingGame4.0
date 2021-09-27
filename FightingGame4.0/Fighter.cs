using System;

namespace FightingGame4._0
{
    public class Fighter
    {
        public string name;
        public int hp;
        Weapon weapon;

        Random rand = new Random();
        int resultDamage;


        public Fighter(string nam, int health, Weapon weap)
        {
            name = nam;
            hp = health;
            weapon = weap;
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
            Console.WriteLine(name);
            Console.WriteLine($"HP: {hp}");
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