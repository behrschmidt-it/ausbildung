using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alter
            int age = 16;

            switch (age)
            {
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Zu jung zum feiern");
                    break;
                case 25:
                    Console.WriteLine("Alles klar, ab gehts");
                    break;
                // wie Else bei einer If Bedingung
                default:
                    Console.WriteLine("Wie alt bist du eigentlich?");
                    break;
            }

            // Als If, Else If, und Else Variante
            if (age == 15)
            {
                Console.WriteLine("Zu jung zum feiern");
            }
            else if (age == 25)
            {
                Console.WriteLine("Alles klar, ab gehts");
            }
            else
            {
                Console.WriteLine("Wie alt bist du eigentlich?");
            }

            string username = "Denis";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("Benutzername ist Denis");
                    break;
                case "root":
                    Console.WriteLine("Benutzername ist root");
                    break;
                default:
                    Console.WriteLine("Benutzername unbekannt");
                    break;
            }

            Console.ReadKey();
        }
    }
}
