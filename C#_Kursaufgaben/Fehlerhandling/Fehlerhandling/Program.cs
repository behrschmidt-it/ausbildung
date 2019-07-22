using System;

namespace Fehlerhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gebe eine Zahl ein:");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
                int result = userInputAsInt / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Druch 0 Teilen ist nicht erlaubt!");
            }
            catch
            {
                Console.WriteLine("Grundlegender Fehler!");
            }



            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("FormatException, das Format war inkorrekt, Du hättest eine Nummer eintragen sollen!");

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, der Wert war leer also (null)!)");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException, der eingegebene Wert war zu lang!");
            }
            finally
            {
                // Verbindung (Datei) noch sauber schließen bei evntuellem Absturz des Systems (Akku leer), o.ä.
                Console.WriteLine("Ich werde soweiso ausgeführt!");
            }

            Console.ReadKey();
        }
    }
}
