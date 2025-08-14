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
            Console.WriteLine();
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
            Thread.Sleep(1000);
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Thread.Sleep(200);
                RedrawGitflowArt(gitflowArt);
                Thread.Sleep(200);
            }

            PrintMessage();
        }

        static void RedrawGitflowArt(string[] art)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (string line in art)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }
        static void PrintMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string message = "       GRACIAS POR SU PARTICIPACIÓN.........            ";

            
                foreach (char c in message)
                {
                    Console.Write(c);
                    Thread.Sleep(2);
                }

            Console.WriteLine();            
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
            EjecutarOpcion(opcion);
        }
        static void EjecutarOpcion(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("GitFlow inicializado con ramas: master, develop");
                    break;
                case "2":
                    Console.Write("Nombre de la feature: ");
                    string feature = Console.ReadLine();
                    Console.WriteLine($"Rama 'feature-{feature}' creada desde 'develop'");
                    break;
                case "3":
                    Console.Write("Versión de release: ");
                    string release = Console.ReadLine();
                    Console.WriteLine($"Rama 'release-{release}' creada desde 'develop'(Para RGC ACTIVA es basada de master)");
                    break;
                case "4":
                    Console.Write("Nombre del hotfix: ");
                    string hotfix = Console.ReadLine();
                    Console.WriteLine($"Rama 'hotfix-{hotfix}' creada desde 'master'");
                    break;
                case "5":
                    Console.WriteLine("Saliendo del simulador...");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            MostrarMenu();
        }
    }
}
