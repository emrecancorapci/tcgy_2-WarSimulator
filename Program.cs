using System;
using tcgy_2_WarSimulator.Simulator;
using tcgy_2_WarSimulator.Simulator.ConsoleOutput;

namespace tcgy_2_WarSimulator
{
    internal class Program
    {
        private static void Main()
        {
            Console.SetWindowSize(SimulatorSettings.WindowWidth, SimulatorSettings.WindowHeight);

            SimulationConsole.Banner();

            CreateSimulation.War();
        }
    }
}
