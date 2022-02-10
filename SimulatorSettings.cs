using System;

namespace tcgy_2_WarSimulator
{
    internal static class SimulatorSettings
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
        public static bool AttackInfo { get; private set; }
        public static bool DeadInfo { get; private set; } = true;

        #endregion

        public static int MinimumDamage { get; private set; } = 2;
        public static int Health { get; private set; } = 100;

    }
}
