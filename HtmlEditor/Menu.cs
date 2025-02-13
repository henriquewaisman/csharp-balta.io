using System;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            DrawScreen();
            WriteOption();

            var option = short.Parse(Console.ReadLine());
            HandleOption(option);
        }
        static void HandleOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.GetTxt(); break;
                case 3:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }; break;
                default: Show(); break;
            }
        }
        static void WriteOption()
        {
            Console.SetCursorPosition(3, 1);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 2);
            Console.Write("============");
            Console.SetCursorPosition(3, 3);
            Console.Write("Selecione uma opção:");
            Console.SetCursorPosition(3, 4);
            Console.Write("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 5);
            Console.Write("2 - Abrir");
            Console.SetCursorPosition(3, 6);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 7);
            Console.Write("Opçao: ");
        }
        static void DrawScreen()
        {
            Console.Clear();
            DrawLines();
            DrawColumns(8);
            DrawLines();
        }
        static void DrawLines()
        {
            Console.Write("+");
            for (int lines = 0; lines < 28; lines++)
            {

                Console.Write("-");
            }
            Console.WriteLine("+");
        }
        static void DrawColumns(int numberOfColumns)
        {
            for (int columns = 0; columns < numberOfColumns; columns++)
            {

                Console.Write("|");

                for (int blank = 0; blank < 28; blank++)
                {

                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
        }
    }
}