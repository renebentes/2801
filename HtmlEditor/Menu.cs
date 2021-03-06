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
            WriteOptions();

            _ = short.TryParse(Console.ReadLine(), out short option);
            HandleMenuOption(option);
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

        private static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção:");
        }

        private static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                {
                    Editor.Show();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("View");
                    break;
                }
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default:
                {
                    Show();
                    break;
                }
            }
        }
    }
}
