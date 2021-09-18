using System;

namespace HtmlEditor
{
    public static class Menu
    {

        private const string BottomLeftCorner = "└";
        private const string BottomRightCorner = "┘";
        private const string Dash = "-";
        private const string Pipe = "|";
        private const string TopLeftCorner = "┌";
        private const string TopRightCorner = "┐";

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
        }

        private static void DrawScreen()
        {
            DrawTopBar();
            DrawContent();
            DrawBottomBar();
        }

        private static void DrawContent()
        {
            for (int lines = 0; lines < 10; lines++)
            {
                Console.Write(Pipe);
                for (int columns = 0; columns < 30; columns++)
                {
                    Console.Write(" ");
                }
                Console.Write($"{Pipe}{Environment.NewLine}");
            }
        }

        private static void DrawBottomBar()
        {
            Console.Write(BottomLeftCorner);
            for (int columns = 0; columns < 30; columns++)
            {
                Console.Write(Dash);
            }
            Console.Write($"{BottomRightCorner}{Environment.NewLine}");
        }

        private static void DrawTopBar()
        {
            Console.Write(TopLeftCorner);
            for (int columns = 0; columns < 30; columns++)
            {
                Console.Write(Dash);
            }
            Console.Write($"{TopRightCorner}{Environment.NewLine}");
        }
    }
}
