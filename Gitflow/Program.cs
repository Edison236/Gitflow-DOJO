using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gitflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equipo de trabajo: ARG0");
            PrintGitflowArt();
            MostrarMenu();
        }
        /// <summary>
        static void PrintGitflowArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[] gitflowArt = new string[]
            {
                @"   ____ _ _   _____ _                   ",
                @"  / ___(_) |_|  ___| | ___   __      __ ",
                @" | |  _| | __| |_  | |/ _ \ |  \_/\_/  |",
                @" | |_| | | |_|  _| | | (_) || |  /\  | |",
                @"  \____|_| \__|_|  | |\___/  \__/  \__/ "
            };
            foreach (string line in gitflowArt)
            {
                foreach (char c in line)
                {
                    Console.Write(c);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
        static void MostrarMenu()
        {
            Console.WriteLine("=== Simulador GitFlow ===");
            Console.WriteLine("1. Inicializar GitFlow");
            Console.WriteLine("2. Crear rama 'feature'");
            Console.WriteLine("3. Crear rama 'release'");
            Console.WriteLine("4. Crear rama 'hotfix'");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();
        }
    }
}
