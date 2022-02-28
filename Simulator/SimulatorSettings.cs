using System;

namespace tcgy_2_WarSimulator.Simulator
{
    internal static class SimulatorSettings
    {
        public static int WindowWidth { get; private set; } = 150;
        public static int WindowHeight => Console.WindowHeight;
        public static int MinimumDamage { get; private set; } = 1;
        public static int Health { get; private set; } = 100;
    }
}
