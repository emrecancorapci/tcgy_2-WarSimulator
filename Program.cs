using tcgy_2_WarSimulator.Simulator;

namespace tcgy_2_WarSimulator
{
    internal class Program
    {
        private static void Main()
        {
            var menu = new Menu();
            menu.Banner();

            CreateSimulation.CreateArmyBattle();
        }
    }
}
