using System;
using System.Collections.Generic;

namespace FightingGame4._0
{
    public class Interface
    {

        public static void CharacterSelect(List<Fighter> characters)
        {
            for (int i = 0; i <= characters.Count; i++)
            {
                Console.WriteLine(characters[i].name);
            }
        }
    }
}