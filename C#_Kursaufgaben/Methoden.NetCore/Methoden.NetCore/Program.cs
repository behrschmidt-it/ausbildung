using System;

namespace Methoden.NetCore
{
    class Program
    {
        // Startpunkt des Programmes
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteSomething();
            WriteSomething();
            WriteSomething();
            string myArgument = "Hallo ich bin super Text!"; // Agrument(Parameter)"
            WriteSomethingSpecific(myArgument); // Übergabe in den Klammern () als Parameter(Argument)
            Console.ReadKey();
        }

        // Zugriffsmodifizierer (static) Rückgabetyp Methodenname(parameter1, parameter2){Methodenrumpf}
        public static void WriteSomething()
        {
            Console.WriteLine("Ich bin eine Methode!");
        }

        public static void WriteSomethingSpecific(string myText) // Parameter//Argument
        {
            Console.WriteLine(myText);
        }

    }
}
