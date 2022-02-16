using System;
using tcgy_2_WarSimulator.Entities;

namespace tcgy_2_WarSimulator.Simulator
{
    internal static class SimulationConsole
    {
        #region Soldier

        public static string FirstSoldierName { get; private set; } = "Soldier";
        public static string SecondSoldierName { get; private set; } = "Soldier";
        public static ConsoleColor FirstSoldierColor { get; private set; } = ConsoleColor.Blue;
        public static ConsoleColor SecondSoldierColor { get; private set; } = ConsoleColor.Red;

        #endregion

        #region Army

        public static string FirstArmyName { get; private set; } = "The First Army";
        public static string SecondArmyName { get; private set; } = "The Second Army";

        public static ConsoleColor FirstArmyColor { get; private set; } = ConsoleColor.Blue;
        public static ConsoleColor SecondArmyColor { get; private set; } = ConsoleColor.Red;

        #endregion

        #region Output
        public static bool SoldierInfo { get; private set; }
        public static bool FightInfo { get; private set; } = true;
        public static bool AttackInfo { get; private set; } = true;
        public static bool DeadInfo { get; private set; } = true;

        #endregion

        public static void SetFirstArmyColor(ConsoleColor color)
        {
            FirstArmyColor = color;
        }
        public static void SetSecondArmyColor(ConsoleColor color)
        {
            SecondArmyColor = color;
        }

        public static void SetSoldierInfo(bool isAppear)
        {
            SoldierInfo = isAppear;
        }
        public static void SetFightInfo(bool isAppear)
        {
            FightInfo = isAppear;
        }
        public static void SetAttackInfo(bool isAppear)
        {
            AttackInfo = isAppear;
        }
        public static void SetDeadInfo(bool isAppear)
        {
            DeadInfo = isAppear;
        }

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
        public static void ShowFightInfo(Soldier soldier1, Soldier soldier2)
        {
            if (!FightInfo) return;
            WriteColored($"\n{soldier1.Name}({soldier1.Health}) ", FirstSoldierColor);
            Console.Write("with ");
            WriteColored($"{soldier1.Weapon.GetName()} ", FirstSoldierColor);

            Console.Write("VS ");

            WriteColored($"{soldier2.Name}({soldier2.Health}) ", SecondSoldierColor);
            Console.Write("with ");
            WriteColoredLine($"{soldier2.Weapon.GetName()}", SecondSoldierColor);

        }
        public static void ShowAttackInfo(Soldier attacker, Soldier defender, int amount)
        {
            if (!AttackInfo) return;

            WriteColored($"{attacker.Name}({attacker.Health}) ", FirstSoldierColor);
            Console.Write("is attacking to ");
            WriteColored($"{defender.Name}({defender.Health + amount})", SecondSoldierColor);
            Console.Write("with ");
            WriteColoredLine($"{attacker.Weapon.GetName()}!", ConsoleColor.Green);

            WriteColored($"{defender.Name} ", SecondSoldierColor);
            Console.Write("got ");
            WriteColored($"{amount} ", ConsoleColor.DarkRed);

            Console.WriteLine("damage! ");
        }
        public static void ShowSoldierInfo(Soldier soldier)
        {
            if (!SoldierInfo) return;

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
            if (!DeadInfo) return;
            WriteColoredLine($"{soldier.Name} is DEAD!", ConsoleColor.DarkRed);
        }

        public static void ArmyInfo(Army army)
        {
            WriteColoredLine($"An army created with {army.Count} soldiers.",
                ConsoleColor.DarkGreen);
        }

        public static void ArmyWon(bool winningArmy)
        {
            if (winningArmy)
            {
                WriteColored(FirstArmyName + " ", FirstArmyColor);
            }
            else
            {
                WriteColored(SecondArmyName + " ", SecondArmyColor);
            }

            Console.WriteLine("won!");
        }
    }
}
