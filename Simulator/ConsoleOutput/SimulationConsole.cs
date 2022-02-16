using System;
using tcgy_2_WarSimulator.Entities;

namespace tcgy_2_WarSimulator.Simulator.ConsoleOutput
{
    internal static class SimulationConsole
    {
        public static int WindowWidth = 150;
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

        public static void DeadSoldierInfo(Soldier alive, Soldier dead)
        {
            if (!OutputSettings.DeadInfo) return;

            FormattedWrite.Colored(alive.Name, ConsoleColor.Green);
            Console.Write(" is killed ");
            FormattedWrite.Colored(dead.Name, ConsoleColor.Red);
            Console.Write(" with ");
            FormattedWrite.ColoredLine($"{alive.Weapon.GetName()}.", ConsoleColor.Yellow);
        }

        public static void ArmyInfo(Army army)
        {
            FormattedWrite.ColoredLine($"An army created with {army.Count} soldiers.",
                ConsoleColor.DarkGreen);
        }

        public static void ArmyWon(bool winningArmy)
        {
            if (winningArmy) FormattedWrite.Colored(
                $"{OutputSettings.FirstArmyName} ",
                OutputSettings.FirstArmyColor);

            else FormattedWrite.Colored(
                $"{OutputSettings.SecondArmyName} ",
                OutputSettings.SecondArmyColor);
            
            Console.WriteLine("won!");
        }

        public static void Banner()
        {
            Console.SetWindowSize(WindowWidth, Console.WindowHeight);

            FormattedWrite.Line(WindowWidth , '=');

            Console.WriteLine("\n  ▄█     █▄     ▄████████    ▄████████" +
                              "         ▄████████  ▄█     ▄▄▄▄███▄▄▄▄   ███ " +
                              "   █▄   ▄█          ▄████████     ███      ▄█" +
                              "█████▄     ▄████████ \n ███     ███   ███   " +
                              " ███   ███    ███        ███    ███ ███   ▄██" +
                              "▀▀▀███▀▀▀██▄ ███    ███ ███         ███    ██" +
                              "█ ▀█████████▄ ███    ███   ███    ███ \n ███" +
                              "     ███   ███    ███   ███    ███        ███" +
                              "    █▀  ███▌  ███   ███   ███ ███    ███ ███ " +
                              "        ███    ███    ▀███▀▀██ ███    ███   █" +
                              "██    ███ \n ███     ███   ███    ███  ▄███▄" +
                              "▄▄▄██▀        ███        ███▌  ███   ███   ██" +
                              "█ ███    ███ ███         ███    ███     ███  " +
                              " ▀ ███    ███  ▄███▄▄▄▄██▀ \n ███     ███ ▀█" +
                              "██████████ ▀▀███▀▀▀▀▀        ▀███████████ ███" +
                              "▌  ███   ███   ███ ███    ███ ███       ▀████" +
                              "███████     ███     ███    ███ ▀▀███▀▀▀▀▀   " +
                              "\n ███     ███   ███    ███ ▀███████████    " +
                              "           ███ ███   ███   ███   ███ ███    █" +
                              "██ ███         ███    ███     ███     ███    " +
                              "███ ▀███████████ \n ███ ▄█▄ ███   ███    ███" +
                              "   ███    ███         ▄█    ███ ███   ███   █" +
                              "██   ███ ███    ███ ███▌    ▄   ███    ███   " +
                              "  ███     ███    ███   ███    ███ \n  ▀███▀█" +
                              "██▀    ███    █▀    ███    ███       ▄███████" +
                              "█▀  █▀     ▀█   ███   █▀  ████████▀  █████▄▄█" +
                              "█   ███    █▀     ▄████▀    ▀██████▀    ███  " +
                              "  ███ \n                            ███    █" +
                              "██                                           " +
                              "         ▀                                   " +
                              "            ███    ███ ");
            FormattedWrite.Line(WindowWidth, '=');
            FormattedWrite.Space(WindowWidth, 3);
        }
        
    }
}
