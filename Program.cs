using System;
using tcgy_2_WarSimulator.Simulator;
using tcgy_2_WarSimulator.Simulator.ConsoleOutput;

namespace tcgy_2_WarSimulator
{
    internal class Program
    {
        private static void Main()
        {
            SimulationConsole.Banner();
            CreateSimulation.War();
        }
    }
}
