using System;

namespace HtmlEditor
{
    class Viewer
    {
        public static void GetTxt()
        {
            Console.SetCursorPosition(0, 9);
            Console.Write("Digite o caminho do arquivo a ser lido: ");
            string filePath = Console.ReadLine();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }

        public static void Show(string text)
        {
            Console.SetCursorPosition(0, 9);
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO\n-----------");
            Editor.Replace(text);
        }


    }
}
