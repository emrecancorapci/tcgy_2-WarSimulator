using System;
using System.Collections.Generic;

namespace tcgy_2_War_Simulator
{
    internal static class WarSimulator
    {
        public static void CreateBattle(int firstArmySize, int secondArmySize)
        {
            var firstArmy = CreateSoldierList(firstArmySize);
            var secondArmy = CreateSoldierList(secondArmySize);


            while (firstArmy.Count > 0 && secondArmy.Count > 0)
            {

            }
        }

        public static List<Soldier> CreateSoldierList(int length)
        {
            var soldierList = new List<Soldier>();

            for (var i = 0; i < length; i++)
            {
                var soldier = new Soldier();
                soldierList.Add(soldier);
            }

            SimulationConsole.SoldierList(length);

            return soldierList;
        }

        public static Soldier Fight(Soldier soldier1, Soldier soldier2)
        {
            soldier1.Color = ConsoleColor.Blue;
            soldier2.Color = ConsoleColor.Red;

            while (soldier1.IsAlive && soldier2.IsAlive)
            {
                soldier1.Attack(soldier2);
                if (!soldier2.IsAlive) break;

                soldier2.Attack(soldier1);
            }

            var deadSoldier = soldier1.IsAlive ? soldier2 : soldier1;

            return deadSoldier;
        }

        public static void RandomFight()
        {
            var soldier1 = new Soldier();
            var soldier2 = new Soldier();

            Fight(soldier1, soldier2);
        }
    }
}
