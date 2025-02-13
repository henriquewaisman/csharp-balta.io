using System;

namespace HtmlEditor
{
    class Saving
    {
        public static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu.Show();
        }

    }
}