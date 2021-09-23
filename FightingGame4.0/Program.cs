using System;

namespace FightingGame4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.WriteNice("Hello World!");

            Weapon sword = new Weapon("Sword", 100);
            Weapon axe = new Weapon("Axe", 100);

            Fighter walter = new Fighter("Walter", 500, sword);
            Fighter floppa = new Fighter("Floppa", 500, axe);

            walter.Attack(floppa);




            Console.ReadLine();
        }
    }
}
