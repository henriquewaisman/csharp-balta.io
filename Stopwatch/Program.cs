using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Até quando você quer contar?\ns = segundos\nm = minutos");
            Console.WriteLine("(Ex: 10 segundos = 10s / 10 minutos = 10m)");
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1)); //retorna o char final
            int time = int.Parse(data.Substring(0, data.Length - 1)); //retona o data - type em int

            int multiplicador = 1;
            if (type == 'm')
            {
                multiplicador = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            Start(time * multiplicador);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}
