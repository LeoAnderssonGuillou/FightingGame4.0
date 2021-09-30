using System;
using System.Collections.Generic;

namespace FightingGame4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WALTER BATTLE: SPECIAL EDITION");
            Console.WriteLine();

            //Weapons
            Weapon sword = new Weapon("Sword", 100);
            Weapon axe = new Weapon("Axe", 100);

            //Fighters
            Fighter walter = new Fighter("Walter", 600, sword);
            Fighter floppa = new Fighter("Floppa", 500, axe);
            Fighter bingus = new Fighter("Bingus", 450, sword);
            List<Fighter> fighters = new List<Fighter>() { walter, floppa, bingus };

            //Choose fighters
            Utilities.WriteNice("CHOOSE YOUR FIGHTER");
            Fighter fighter1 = GameInterface.CharacterSelect(fighters);
            fighters.Remove(fighter1);
            Utilities.WriteNice("CHOOSE YOUR OPPONENT");
            Fighter fighter2 = GameInterface.CharacterSelect(fighters);

            //Create new Battle
            Battle fight = new Battle(fighter1, fighter2);

            //Actual battle
            while (fighter1.IsAlive() && fighter2.IsAlive())
            {
                fight.PlayRound();
            }
            fight.WhoWon();




            Console.ReadLine();
        }
    }
}
