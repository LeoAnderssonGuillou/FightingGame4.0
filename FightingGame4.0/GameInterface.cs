using System;
using System.Collections.Generic;

namespace FightingGame4._0
{
    public class GameInterface
    {

        public static Fighter CharacterSelect(List<Fighter> characters)
        {
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine($"{characters[i].name} [{i + 1}]");
            }

            Console.WriteLine();
            return characters[Utilities.GetValidInput(characters.Count) - 1];
        }
    }
}