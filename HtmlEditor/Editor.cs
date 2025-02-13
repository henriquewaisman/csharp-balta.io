using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("MODO EDITOR\n-----------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }

            Console.WriteLine("Digite 1 para SALVAR o arquivo\nDigite 2 para VER o arquivo");
            int option = int.Parse(Console.ReadLine());

            var fileStr = file.ToString();

            if (option == 1)
            {
                Saving.Salvar(fileStr);
                Viewer.Show(fileStr);
            }
            else
            {
                Viewer.Show(fileStr);
                Console.WriteLine("\nDeseja SALVAR?\n1 - SIM\n2 - NÃO");
                var optionTwo = int.Parse(Console.ReadLine());
                if (optionTwo == 1)
                {
                    Saving.Salvar(fileStr);
                }
                else
                {
                    Menu.Show();
                }
            }
        }
        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
