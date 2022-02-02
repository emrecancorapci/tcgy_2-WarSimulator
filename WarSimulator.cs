using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgy_2_War_Simulator
{
    internal static class WarSimulator
    {
        public static void Fight(Soldier soldier1, Soldier soldier2)
        {
            soldier1.Color = ConsoleColor.Blue;
            soldier2.Color = ConsoleColor.Red;
            while (soldier1.IsAlive && soldier2.IsAlive)
            {
                soldier1.Attack(soldier2);
                if (!soldier2.IsAlive) break;

                soldier2.Attack(soldier1);
            }
        }

        public static void RandomFight()
        {
            var soldier1 = new Soldier();
            var soldier2 = new Soldier();

            Fight(soldier1, soldier2);
        }
    }
}
