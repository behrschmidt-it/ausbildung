using System;

namespace IfStatementsHerausforderung2
{
    class Program
    {
        // Höchste Punktzahl
        static int highscore = 300;
        // Rekordhalter
        static string highscorePlayer = "Denis";

        static void Main(string[] args)
        {
            CheckHighscore(255, "Frank");
            CheckHighscore(325, "Michaela");
            CheckHighscore(270, "Guido");
            Console.ReadKey();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                
                Console.WriteLine("Neuer Highscore ist {0}", score);
                Console.WriteLine($"Neuer Highscore ist {score}");
                Console.WriteLine("Neuer Rekordhalter ist {0}", playerName);
            }
            else
            {
                Console.WriteLine("Der alte Highscore konnte nicht gebrochen werden. Er ist immer noch " +
                    "{0} und wird von {1} gehalten", highscore, highscorePlayer);
            }
        }
    }
}
