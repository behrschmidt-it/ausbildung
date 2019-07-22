using System;

namespace IfStatementsHErausforderung
{
    class Program
    {
        // Benutzername - static, damit es in einer static Methode verwendet werden kann
        static string username;
        // Passwort - static, damit es in einer static Methode verwendet werden kann
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadKey();
        }

        public static void Register()
        {
            Console.WriteLine("Bitte trage deinen Benutzernamen ein");
            username = Console.ReadLine();
            Console.WriteLine("Bitte trage dein Passwort ein");
            password = Console.ReadLine();
            Console.WriteLine("Registrierung abgeschlossen!");
            Console.WriteLine("-----------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Benutzername eingeben:");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Bitte gib dein Passwort ein");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Einloggen war erfolgreich");
                }
                else
                {
                    Console.WriteLine("Login schiefgegangen, falsches Passwort, starte das Programm neu!");
                }
            }
            else
            {
                Console.WriteLine("Benutzername nicht vorhanden! Bitte versuche es mit einem anderen Benutzername erneut!");
            }
        }
    }
}
