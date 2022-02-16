using System;
using tcgy_2_WarSimulator.Entities;

namespace tcgy_2_WarSimulator.Simulator.ConsoleOutput
{
    internal static class SimulationConsole
    {
        public static void ShowFightInfo(Soldier soldier1, Soldier soldier2)
        {
            if (!OutputSettings.FightInfo) return;
            FormattedWrite.Colored($"\n{soldier1.Name}({soldier1.Health}) ", OutputSettings.FirstSoldierColor);
            Console.Write("with ");
            FormattedWrite.Colored($"{soldier1.Weapon.GetName()} ", OutputSettings.FirstSoldierColor);

            Console.Write("VS ");

            FormattedWrite.Colored($"{soldier2.Name}({soldier2.Health}) ", OutputSettings.SecondSoldierColor);
            Console.Write("with ");
            FormattedWrite.ColoredLine($"{soldier2.Weapon.GetName()}", OutputSettings.SecondSoldierColor);

        }
        public static void ShowAttackInfo(Soldier attacker, Soldier defender, int amount)
        {
            if (!OutputSettings.AttackInfo) return;

            FormattedWrite.Colored($"{attacker.Name}({attacker.Health}) ", OutputSettings.FirstSoldierColor);
            Console.Write("is attacking to ");
            FormattedWrite.Colored($"{defender.Name}({defender.Health + amount})", OutputSettings.SecondSoldierColor);
            Console.Write("with ");
            FormattedWrite.ColoredLine($"{attacker.Weapon.GetName()}!", ConsoleColor.Green);

            FormattedWrite.Colored($"{defender.Name} ", OutputSettings.SecondSoldierColor);
            Console.Write("got ");
            FormattedWrite.Colored($"{amount} ", ConsoleColor.DarkRed);

            Console.WriteLine("damage! ");
        }
        public static void ShowSoldierInfo(Soldier soldier)
        {
            if (!OutputSettings.SoldierInfo) return;

            Console.WriteLine("===========================");

            Console.Write(" Name : ");
            FormattedWrite.ColoredLine($"{soldier.Name}",
                ConsoleColor.Blue);

            Console.Write(" Weapon : ");
            FormattedWrite.ColoredLine($"{soldier.Weapon.GetName()}",
                ConsoleColor.Red);

            Console.Write(" Hit-point : ");
            FormattedWrite.ColoredLine($"{soldier.HitPoint}",
                ConsoleColor.Yellow);

            Console.WriteLine("===========================\n");
        }
        public static void DeadSoldierInfo(Soldier soldier)
        {
            if (!OutputSettings.DeadInfo) return;
            FormattedWrite.ColoredLine($"{soldier.Name} is DEAD!", ConsoleColor.DarkRed);
        }

        public static void ArmyInfo(Army army)
        {
            FormattedWrite.ColoredLine($"An army created with {army.Count} soldiers.",
                ConsoleColor.DarkGreen);
        }

        public static void ArmyWon(bool winningArmy)
        {
            if (winningArmy)
            {
                FormattedWrite.Colored(OutputSettings.FirstArmyName + " ", OutputSettings.FirstArmyColor);
            }
            else
            {
                FormattedWrite.Colored(OutputSettings.SecondArmyName + " ", OutputSettings.SecondArmyColor);
            }

            Console.WriteLine("won!");
        }
    }
}
