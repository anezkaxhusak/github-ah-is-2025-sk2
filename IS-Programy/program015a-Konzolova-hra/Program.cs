using System;
using System.Linq;

namespace Sibenice
{
    class GameState
    {
        public char[] UhodnutaPismena;
        public int Chyby;
        public int SpravneUhodnuti;
        public string VybraneSlovo;
    }

    class Program
    {
        const int MAX_TRIES = 3;

        static Random random = new Random();

        static void Main()
        {
            char playAgain;

            do
            {
                PlayOneGame();
                Console.Write("\nChcete hrát znovu? (a/n): ");
                playAgain = GetValidChar();
            }
            while (playAgain == 'a');

            Console.WriteLine("\nDěkujeme za hru!");
        }

        static void PlayOneGame()
        {
            GameState game = new GameState();

            SelectRandomWord(game);
            InitializeGameState(game);

            Console.WriteLine("\nVítejte ve hře šibenice! Hra je na téma ptáci");
            Console.WriteLine("Pozor: Nepoužívejte písmena s háčky a čárkami\n");

            while (game.Chyby < MAX_TRIES &&
                   game.SpravneUhodnuti < game.VybraneSlovo.Length)
            {
                DisplayGameState(game);
                Console.Write("Zadejte písmeno: ");
                char guess = GetValidChar();
                ProcessGuess(game, guess);
            }

            DisplayGameResult(game);
        }

        static void SelectRandomWord(GameState game)
        {
            string[] words =
            {
                "stehlik", "vrabec", "pelikan", "vrana", "krkavec",
                "sokol", "sova", "kukacka", "holub", "sojka",
                "krepelka", "kormoran", "racek", "kachna", "strakapoud",
                "sykora", "vlastovka", "straka", "skrivan", "harpyje", 
                "cervenka", "husa", "volavka", "havran", "havran",
                "datel",
            };

            game.VybraneSlovo = words[random.Next(words.Length)];
        }

        static void InitializeGameState(GameState game)
        {
            game.Chyby = 0;
            game.SpravneUhodnuti = 0;
            game.UhodnutaPismena = Enumerable.Repeat('*', game.VybraneSlovo.Length).ToArray();
        }

        static void DisplayGameState(GameState game)
        {
            Console.WriteLine("\nSlovo: " + new string(game.UhodnutaPismena));
        }

        static char GetValidChar()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 1 && char.IsLetter(input[0]))
                {
                    return char.ToLower(input[0]);
                }

                Console.Write("Neplatný vstup. Zadejte prosím jedno písmeno: ");
            }
        }

        static void ProcessGuess(GameState game, char guess)
        {
            bool uhodnuto = false;

            for (int i = 0; i < game.VybraneSlovo.Length; i++)
            {
                if (game.VybraneSlovo[i] == guess &&
                    game.UhodnutaPismena[i] == '*')
                {
                    game.UhodnutaPismena[i] = guess;
                    game.SpravneUhodnuti++;
                    uhodnuto = true;
                }
            }

            if (!uhodnuto)
            {
                game.Chyby++;
                Console.WriteLine("\nŠpatně!");
                NakresliObesence(game.Chyby);
            }
            else
            {
                Console.WriteLine("\nSprávně!");
            }
        }

        static void DisplayGameResult(GameState game)
        {
            Console.WriteLine("\nKonec hry!");
            if (game.Chyby == MAX_TRIES)
            {
                Console.WriteLine("Prohráli jste! Hledané slovo bylo: {0}! ",game.VybraneSlovo);
            }
            else
            {
                Console.WriteLine("Vyhráli jste! Uhodli jste slovo: {0}! ", game.VybraneSlovo);
            }
        }

        static void NakresliObesence(int chyby)
        {
            Console.WriteLine();
            switch (chyby)
            {
                case 1:
                    Console.WriteLine("    ___");
                    Console.WriteLine("   /   \\");
                    Console.WriteLine("  /     \\");
                    Console.WriteLine(" /       \\");
                    Console.WriteLine("/         \\");
                    break;

                case 2:
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine("     |");
                    Console.WriteLine("    _|_");
                    Console.WriteLine("   /   \\");
                    Console.WriteLine("  /     \\");
                    Console.WriteLine(" /       \\");
                    Console.WriteLine("/         \\");
                    break;

                case 3:
                    Console.WriteLine("     _______");
                    Console.WriteLine("     |/    |");
                    Console.WriteLine("     |     O");
                    Console.WriteLine("     |    /|\\");
                    Console.WriteLine("     |    / \\");
                    Console.WriteLine("     |");
                    Console.WriteLine("    _|_");
                    Console.WriteLine("   /   \\");
                    Console.WriteLine("  /     \\");
                    Console.WriteLine(" /       \\");
                    Console.WriteLine("/         \\");
                    break;
            }
        }
    }
}