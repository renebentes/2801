using System;
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
            Console.Write("Deseja salvar o arquivo?[s/n]: ");

            _ = char.TryParse(Console.ReadLine().ToLowerInvariant(), out char response);

            if (response == 's')
            {
                Save(content.ToString());
            }

            Viewer.Show(content.ToString());
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            string path = Console.ReadLine();

            try
            {
                using var file = new StreamWriter(path);
                file.Write(text);

                Console.WriteLine($"Arquivo salvo com sucesso em {path}!");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
