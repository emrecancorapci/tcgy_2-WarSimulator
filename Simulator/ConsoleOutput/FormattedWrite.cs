using System;

namespace tcgy_2_WarSimulator.Simulator.ConsoleOutput
{
    internal static class FormattedWrite
    {
        public static void Colored(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ColoredLine(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
