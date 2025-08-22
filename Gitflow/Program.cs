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
    }
}
