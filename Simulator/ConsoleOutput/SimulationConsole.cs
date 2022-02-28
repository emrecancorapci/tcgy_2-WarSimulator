using System;
using tcgy_2_WarSimulator.Entities;
using static System.Console;
using static tcgy_2_WarSimulator.Simulator.ConsoleOutput.FormattedWrite;

namespace tcgy_2_WarSimulator.Simulator.ConsoleOutput
{
    internal static class SimulationConsole
    {
        public static int WindowWidth = SimulatorSettings.WindowWidth;
        public static void ShowFightInfo(Soldier soldier1, Soldier soldier2)
        {
            if (!OutputSettings.FightInfo) return;

            Colored($"\n{soldier1.Name}({soldier1.Health}) ", OutputSettings.FirstSoldierColor);
            Write("with ");
            Colored($"{soldier1.Weapon.GetName()} ", OutputSettings.FirstSoldierColor);

            Write("VS ");

            Colored($"{soldier2.Name}({soldier2.Health}) ", OutputSettings.SecondSoldierColor);
            Write("with ");
            ColoredLine($"{soldier2.Weapon.GetName()}", OutputSettings.SecondSoldierColor);

        }
        public static void ShowAttackInfo(Soldier attacker, Soldier defender, int amount)
        {
            if (!OutputSettings.AttackInfo) return;

            Colored($"{attacker.Name}({attacker.Health}) ", OutputSettings.FirstSoldierColor);
            Write("is attacking to ");
            Colored($"{defender.Name}({defender.Health + amount})", OutputSettings.SecondSoldierColor);
            Write("with ");
            ColoredLine($"{attacker.Weapon.GetName()}!", ConsoleColor.Green);

            Colored($"{defender.Name} ", OutputSettings.SecondSoldierColor);
            Write("got ");
            Colored($"{amount} ", ConsoleColor.DarkRed);

            WriteLine("damage! ");
        }
        public static void ShowSoldierInfo(Soldier soldier)
        {
            if (!OutputSettings.SoldierInfo) return;

            WriteLine("===========================");

            Write(" Name : ");
            ColoredLine($"{soldier.Name}", ConsoleColor.Blue);

            Write(" Weapon : ");
            ColoredLine($"{soldier.Weapon.GetName()}", ConsoleColor.Red);

            Write(" Hit-point : ");
            ColoredLine($"{soldier.HitPoint}", ConsoleColor.Yellow);

            WriteLine("===========================\n");
        }
        public static void ShowSoldiersInfo(Soldier soldier, Soldier soldier2)
        {
            if (!OutputSettings.SoldierInfo) return;

            ShowSoldierInfo(soldier);
            ShowSoldierInfo(soldier2);
        }
        public static void DeadSoldierInfo(Soldier soldier)
        {
            if (!OutputSettings.DeadInfo) return;
            ColoredLine($"{soldier.Name} is DEAD!", ConsoleColor.DarkRed);
        }

        public static void DeadSoldierInfo(Soldier alive, Soldier dead)
        {
            if (!OutputSettings.DeadInfo) return;

            Colored(alive.Name, ConsoleColor.Green);
            Write(" is killed ");
            Colored(dead.Name, ConsoleColor.Red);
            Write(" with ");
            ColoredLine($"{alive.Weapon.GetName()}.", ConsoleColor.Yellow);
        }

        public static void ArmyInfo(Army army)
        {
            ColoredLine($"An army created with {army.Count} soldiers.",
                ConsoleColor.DarkGreen);
        }

        public static void ArmyWon(bool winningArmy)
        {
            if (winningArmy) Colored($"{OutputSettings.FirstArmyName} ",
                OutputSettings.FirstArmyColor);

            else Colored($"{OutputSettings.SecondArmyName} ",
                OutputSettings.SecondArmyColor);
            
            WriteLine("won!");
        }

        public static void Banner()
        {
            DrawLine(WindowWidth , '=');

            WriteLine("\n  ▄█     █▄     ▄████████    ▄████████" +
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
            DrawLine(WindowWidth, '=');
            Space(WindowWidth, 3);
        }
        
    }
}
