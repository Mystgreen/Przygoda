using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygoda_1
{
    //Menu budowane z pomocą: Tutorial C#. Jak zrobić proste menu w aplikacji konsolowej #1 | Videopoint.pl
    static class Menu
    {
        public static void MenuFields()
        {
            Console.Title = "Menu of game - Simple Tibia adventure by Martin K.";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome in game - Simple Tibia adventure by Martin K." + "\n\n");
                Console.WriteLine("<<<MENU>>\n");
                Console.WriteLine("1 - Start game");
                Console.WriteLine("2 - Settings");
                Console.WriteLine("3 - Exit game");

                ConsoleKeyInfo button = Console.ReadKey();
                switch (button.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); StartingGame(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); GameSettings(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0); break;
                    default:
                        break;
                }
            }
        }
        static void StartingGame()
        {
            Console.WriteLine("Opcja do rozbudowania tutaj zaczniesz grę");
            Console.ReadKey();
        }
        static void GameSettings()
        {
            Console.WriteLine("Tutaj nadasz imię postaci, wybierzesz rasę lub poziom trudności?");
            Console.ReadKey();


        }
    }
}
