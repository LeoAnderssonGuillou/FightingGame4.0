using System;
using System.Collections.Generic;

namespace FightingGame4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.WriteNice("Hello World!");

            Weapon sword = new Weapon("Sword", 100);
            Weapon axe = new Weapon("Axe", 100);

            Fighter walter = new Fighter("Walter", 600, sword);
            Fighter floppa = new Fighter("Floppa", 500, axe);

            List<Fighter> fighters = new List<Fighter>() { walter, floppa };

            Interface.CharacterSelect(fighters);
            Fighter fighter1 = walter;
            Fighter fighter2 = floppa;
            Battle fight = new Battle(fighter1, fighter2);


            while (fighter1.IsAlive() && fighter2.IsAlive())
            {
                fight.PlayRound();
            }
            fight.WhoWon();




            Console.ReadLine();
        }
    }
}
