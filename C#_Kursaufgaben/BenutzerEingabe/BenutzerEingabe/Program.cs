using System;

namespace BenutzerEingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Benutzereingabe wird in einer string Variablen gespeichert
            //Console.WriteLine("Benutzereingabe bereit! Geben Sie einen Text ein: ");
            //string input = Console.ReadLine();
            //Console.WriteLine("Benutzereingabe war: {0}", input);

            // Console.WriteLine(Calculate());
            Calculate();
            Console.ReadKey();
        }

        public static void Calculate() // int Rückgabe bei 1 Version
        {
            Console.WriteLine("Bitte trage die erste Zahl ein (nur zahlen!):");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Bitte trage die zweite zahl ein (nur zahlen!):");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            //return result;
            Console.WriteLine(result);
        }
    }
}
