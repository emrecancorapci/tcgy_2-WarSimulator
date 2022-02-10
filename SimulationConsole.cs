using System;

namespace tcgy_2_WarSimulator
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
        public static void FightInfo(Soldier soldier1, Soldier soldier2)
        {
            WriteColored($"{soldier1.Name}({soldier1.Health}) ", SimulatorSettings.FirstSoldierColor);
            Console.Write("with ");
            WriteColored($"{soldier1.Weapon.GetName()} ", SimulatorSettings.FirstSoldierColor);

            Console.Write("VS ");

            WriteColored($"{soldier2.Name}({soldier2.Health}) ", SimulatorSettings.SecondSoldierColor);
            Console.Write("with ");
            WriteColoredLine($"{soldier2.Weapon.GetName()}", SimulatorSettings.SecondSoldierColor);

        }
        public static void AttackInfo(Soldier attacker, Soldier defender, int amount)
        {
            WriteColored($"{attacker.Name}({attacker.Health}) ", SimulatorSettings.FirstSoldierColor);
            Console.Write("is attacking to ");
            WriteColored($"{defender.Name}({defender.Health + amount})", SimulatorSettings.SecondSoldierColor);
            Console.Write("with ");
            WriteColoredLine($"{attacker.Weapon.GetName()}!\n", ConsoleColor.Green);

            WriteColored($"{defender.Name} ", SimulatorSettings.SecondSoldierColor);
            Console.Write("got ");
            WriteColored($"{amount} ", ConsoleColor.DarkRed);

            Console.WriteLine("damage! ");
        }
        public static void SoldierInfo(Soldier soldier)
        {
            Console.WriteLine("===========================");

            Console.Write(" Name : ");
            WriteColoredLine($"{soldier.Name}",
                ConsoleColor.Blue);

            Console.Write(" Weapon : ");
            WriteColoredLine($"{soldier.Weapon.GetName()}",
                ConsoleColor.Red);

            Console.Write(" Hit-point : ");
            WriteColoredLine($"{soldier.HitPoint}",
                ConsoleColor.Yellow);

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

        public static void ArmyWon(bool winningArmy)
        {
            if (winningArmy)
            {
                WriteColored(SimulatorSettings.FirstArmyName + " ", SimulatorSettings.FirstArmyColor);
            }
            else
            {
                WriteColored(SimulatorSettings.SecondArmyName + " ", SimulatorSettings.SecondArmyColor);
            }

            Console.WriteLine("won!");
        }
    }
}
