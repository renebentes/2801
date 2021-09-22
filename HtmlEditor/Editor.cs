using System.Text;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO DE EDIÇÃO");
            Console.WriteLine("==============");

            Start();
        }

        public static void Start()
        {
            var content = new StringBuilder();

            do
            {
                content.AppendLine(Console.ReadLine());
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------------------");
            Console.WriteLine("Deseja salvar o arquivo?");
        }
    }
}
