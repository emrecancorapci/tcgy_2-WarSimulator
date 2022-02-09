using System;
using System.Collections.Generic;

namespace tcgy_2_War_Simulator
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

            var winningArmy = firstArmy.Count == 0 ?
                (secondArmy.Count == 0 ? "draw" : "second") : "first";
            SimulationConsole.ArmyWon(winningArmy);

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
            soldier1.Color = ConsoleColor.Blue;
            soldier2.Color = ConsoleColor.Red;

            while (soldier1.IsAlive && soldier2.IsAlive)
            {
                soldier1.Attack(soldier2);
                if (!soldier2.IsAlive) break;

                soldier2.Attack(soldier1);
            }
            
            var isSoldier1Alive = soldier1.IsAlive;

            return isSoldier1Alive;
        }

        public static void RandomFight()
        {
            var soldier1 = new Soldier();
            var soldier2 = new Soldier();

            Fight(soldier1, soldier2);
        }
    }
}
