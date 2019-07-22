using System;

namespace ImpliziteUndExpleziteKonvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implizite Konvertierung

            int num = 1234567;
            long bigNum = num;

            float myFloat = 13.37f;
            double myDouble = myFloat;

            // Explizite Konvertierung

            int myInt;
            double myNewDouble = 13.37;

            myInt = (int)myNewDouble;

            string myString = myNewDouble.ToString();
            string myString2 = myString + "12";

            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.ReadKey();
        }
    }
}
