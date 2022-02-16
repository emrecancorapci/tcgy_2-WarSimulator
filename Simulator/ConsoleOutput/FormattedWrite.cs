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
        public static string Centered(string str, int width = 150)
        { 
            
            var plus = width == 0 ? - 2 : - 1;
            var spaceToCenter = (width + plus) / 2 - str.Length / 2;
            var space = "";

            for (var i = 0; i < spaceToCenter; i++)
            {
                space += " ";
            }

            return $"#{space}{str}{space}#";
        }
        public static void Space(int width, int repeat = 1)
        {
            var space = "";

            for (var i = 0; i < width - 2; i++)
            {
                space += " ";
            }

            for (var i = 0; i < repeat; i++)
            {
                Console.WriteLine($"#{space}#");
            }
        }
        public static void Line(int length, char character)
        {
            var line = "";

            for (var i = 0; i < length; i++)
            {
                line += character;
            }

            Console.Write(line + "\n");
        }
    }
}
