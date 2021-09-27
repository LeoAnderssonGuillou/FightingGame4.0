using System;

namespace FightingGame4._0
{
    public class Fighter
    {
        string name;
        int hp;
        Weapon weapon;


        public Fighter(string nam, int health, Weapon weap)
        {
            name = nam;
            hp = health;
            weapon = weap;
        }

        public void Attack(Fighter target)
        {
            Utilities.WriteNice($"{name} strikes {target.name}!");
            Utilities.WriteNice($"{weapon.attack} damage!");
            target.hp -= weapon.attack;
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