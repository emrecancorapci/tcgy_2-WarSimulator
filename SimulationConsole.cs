using System;
using System.Collections.Generic;
using System.IO;

namespace tcgy_2_War_Simulator
{
    internal static class SimulationConsole
    {
        private static void WriteColored(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void WriteColoredLine(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void AttackInfo(Soldier attacker, Soldier defender)
        {
            WriteColored($"{attacker.Name}({attacker.Health})", attacker.Color);
            WriteColored(" is attacking to ", ConsoleColor.White);
            WriteColored($"{defender.Name}({defender.Health})", defender.Color);
            WriteColored(" with ", ConsoleColor.White);
            WriteColored($"{attacker.Weapon.GetName()}!\n", ConsoleColor.Green);
        }
        public static void AttackOutput(Soldier defender, int amount)
        {
            WriteColored($"{defender.Name}", defender.Color);
            WriteColored(" got ", ConsoleColor.White);
            WriteColored($"{amount}", ConsoleColor.Red);
            WriteColored(" damage!\n", ConsoleColor.White);
        }
        public static void SoldierInfo(Soldier soldier)
        {
            Console.WriteLine("===========================");

            Console.Write(" Name : ");
            WriteColoredLine($"{soldier.Name}", ConsoleColor.Blue);

            Console.Write(" Weapon : ");
            WriteColoredLine($"{soldier.Weapon.GetName()}", ConsoleColor.Red);

            Console.Write(" Hit-point : ");
            WriteColoredLine($"{soldier.HitPoint}", ConsoleColor.Yellow);

            Console.WriteLine("===========================\n");
        }
        public static void DeadSoldierInfo(Soldier soldier)
        {
            WriteColoredLine($"{soldier.Name} is DEAD!", ConsoleColor.DarkRed);
        }

        public static void Army(int length)
        {
            WriteColoredLine($"An army created with {length} soldiers.",
                ConsoleColor.DarkGreen);
        }

        public static void ArmyWon(string winningArmy)
        {
            if (winningArmy != null)
            {
                if (winningArmy == "first")
                {
                    WriteColored("The first army ", ConsoleColor.Blue);
                }
                else
                {
                    WriteColored("The second army ", ConsoleColor.Red);
                }
                Console.WriteLine("won!");
            }
            else
            {
                Console.WriteLine("Nobody won. :(");
            }
        }
    }
}
