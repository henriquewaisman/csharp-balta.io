using System;
using System.ComponentModel.Design;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }
        static void Soma()
        {
            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 + n2;
            Console.WriteLine("O resultado é " + resultado);
            Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 - n2;
            Console.WriteLine("O resultado é " + resultado);
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 * n2;
            Console.WriteLine("O resultado é " + resultado);
            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());
            float resultado = n1 / n2;
            Console.WriteLine("O resultado é " + resultado);
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.Clear();
            Console.Write("Escolha uma operação:\n1. Soma\n2. Subtração\n3. Multiplicação\n4. Divisão\n5. Sair\nOperação: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
    }
}
