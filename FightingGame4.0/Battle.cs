using System;

namespace FightingGame4._0
{
    public class Battle
    {
        int round = 1;
        Fighter fighter1;
        Fighter fighter2;


        public Battle(Fighter fA, Fighter fB)
        {
            fighter1 = fA;
            fighter2 = fB;
        }

        public void PlayRound()
        {
            Utilities.WriteNice($"ROUND {round}");
            fighter1.Attack(fighter2);
            fighter2.Attack(fighter1);
            Console.WriteLine();

            fighter1.PrintStats();
            fighter2.PrintStats();

            Console.ReadLine();
            round++;
        }

        public void WhoWon()
        {
            if (fighter1.hp > 0)
            {
                Utilities.WriteNice($"{fighter1.name} wins!");
            }
            else if (fighter2.hp > 0)
            {
                Utilities.WriteNice($"{fighter2.name} wins!");
            }
            else
            {
                Utilities.WriteNice("It's a tie!");
            }
        }

    }
}