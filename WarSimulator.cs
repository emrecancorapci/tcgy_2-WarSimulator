using System.Collections.Generic;

namespace tcgy_2_WarSimulator
{
    internal static class WarSimulator
    {
        public static void CreateBattle(int firstArmySize, int secondArmySize)
        {
            var firstArmy = CreateArmy(firstArmySize);
            var secondArmy = CreateArmy(secondArmySize);

            while (firstArmy.Count > 0 && secondArmy.Count > 0)
            {
                var soldier1 = firstArmy.Dequeue();
                var soldier2 = secondArmy.Dequeue();

                var isFirstSoldierWin = Fight(soldier1, soldier2);

                if (isFirstSoldierWin) firstArmy.Enqueue(soldier1);
                else secondArmy.Enqueue(soldier2);
            }

            var isFirstArmyWin = firstArmy.Count != 0;

            SimulationConsole.ArmyWon(isFirstArmyWin);

        }

        public static Queue<Soldier> CreateArmy(int size)
        {
            var soldierList = new Queue<Soldier>();

            for (var i = 0; i < size; i++)
            {
                var soldier = new Soldier();
                soldierList.Enqueue(soldier);
            }

            SimulationConsole.Army(size);

            return soldierList;
        }

        public static bool Fight(Soldier soldier1, Soldier soldier2)
        {
            if(SimulatorSettings.FightInfo) SimulationConsole.FightInfo(soldier1, soldier2);

            while (soldier1.IsAlive && soldier2.IsAlive)
            {
                var damage = soldier1.Attack(soldier2);

                if(SimulatorSettings.AttackInfo) SimulationConsole.AttackInfo(soldier1, soldier2, damage);

                if (!soldier2.IsAlive)
                {
                    if(SimulatorSettings.DeadInfo) SimulationConsole.DeadSoldierInfo(soldier2);
                    break;
                }

                soldier2.Attack(soldier1);

                if (soldier1.IsAlive & SimulatorSettings.DeadInfo) continue;
                
                SimulationConsole.DeadSoldierInfo(soldier1);
            }

            return soldier1.IsAlive;
        }

        public static void RandomFight()
        {
            var soldier1 = new Soldier();
            var soldier2 = new Soldier();

            if (SimulatorSettings.SoldierInfo)
            {
                SimulationConsole.SoldierInfo(soldier1);
                SimulationConsole.SoldierInfo(soldier2);
            }

            Fight(soldier1, soldier2);
        }
    }
}
