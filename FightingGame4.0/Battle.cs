using System;

namespace FightingGame4._0
{
    public class Battle
    {
        int round = 1;


        public void PlayRound(Fighter fighter1, Fighter fighter2)
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

    }
}