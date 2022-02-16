using System;
using tcgy_2_WarSimulator.Entities;
using tcgy_2_WarSimulator.Simulator.ConsoleOutput;

namespace tcgy_2_WarSimulator.Simulator
{
    internal static class CreateSimulation
    {
        #region Army

        public static void War(int firstArmySize = 10, int secondArmySize = 10)
        {
            if (firstArmySize <= 0) throw new ArgumentOutOfRangeException(nameof(firstArmySize));
            if (secondArmySize <= 0) throw new ArgumentOutOfRangeException(nameof(secondArmySize));

            var firstArmy = new Army(firstArmySize, OutputSettings.FirstArmyName);
            var secondArmy = new Army(secondArmySize, OutputSettings.SecondArmyName);

            SimulationConsole.ArmyInfo(firstArmy);
            SimulationConsole.ArmyInfo(secondArmy);

            var isFirstArmyWin = ArmyBattle(firstArmy, secondArmy);

            SimulationConsole.ArmyWon(isFirstArmyWin);
        }

        public static bool ArmyBattle(Army army1, Army army2)
        {
            while (army1.Count > 0 && army2.Count > 0)
            {
                var soldier1 = army1.GetSolider();
                var soldier2 = army2.GetSolider();

                var isFirstSoldierWin = Fight(soldier1, soldier2);

                if (isFirstSoldierWin) army1.AddSoldier(soldier1);
                else army2.AddSoldier(soldier2);
            }
            return army1.Count != 0;
        }

        #endregion


        public static void Battle()
        {
            var soldier1 = new Soldier();
            var soldier2 = new Soldier();

            SimulationConsole.ShowSoldierInfo(soldier1);
            SimulationConsole.ShowSoldierInfo(soldier2);

            Fight(soldier1, soldier2);
        }

        public static bool Fight(Soldier soldier1, Soldier soldier2)
        {
            SimulationConsole.ShowFightInfo(soldier1, soldier2);

            while (soldier1.IsAlive && soldier2.IsAlive)
            {
                Attack(soldier1, soldier2);
                Attack(soldier2, soldier1);
            }

            var deadSoldier = soldier1.IsAlive ? soldier2 : soldier1;
            SimulationConsole.DeadSoldierInfo(deadSoldier);

            return soldier1.IsAlive;
        }

        public static void Attack(Soldier attacker, Soldier defender)
        {
            if (!defender.IsAlive || !attacker.IsAlive) return;

            var damageAmount = attacker.GiveDamage();
            defender.GetDamage(damageAmount);

            SimulationConsole.ShowAttackInfo(attacker, defender, damageAmount);
        }
    }
}
