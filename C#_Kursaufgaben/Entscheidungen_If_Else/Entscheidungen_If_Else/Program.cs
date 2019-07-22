using System;

namespace Entscheidungen_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {

            // if(Bedingung)
            // {
            //      ausführender Code
            // }

            // Infotext
            Console.WriteLine("Wie warm ies es grade? Trage den Wert als Zahl ein");
            //Benutzereingabe
            string temperatureInput = Console.ReadLine();
            //int temperatrure = int.Parse(temperatureInput);
            int temperature;
            int number;

            bool userEnteredANumber = int.TryParse(temperatureInput, out number);

            if (userEnteredANumber)
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
            }

            if (temperature < 20)
            {
                Console.WriteLine("Zieh deine Jacke an!");
            }
            else if (temperature == 20)
            {
                Console.WriteLine("Es ist genau 10 Grad C Warm");
            }
            else if (temperature > 30)
            {
                Console.WriteLine("Es ist eine Bullenhitze!");
            }
            else
            {
                Console.WriteLine("Zwischen 21 und 30 Grad C° - T-Shirt und kurze Hose reicht!");
            }

            Console.ReadKey();
        }
    }
}
