using System;

namespace VerschachtelteIfBedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = true;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Bitte trage deinen Benutzernamen ein!");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName == "Admin")
            {
                Console.WriteLine("Halo registrierter Nutzer!");
                Console.WriteLine("Hi {0}", userName);
                Console.WriteLine("Hallo Admin!");
            }
            //else
            //{
            //    Console.WriteLine("Hallo unregistrierter Mensch!");
            //    if (!isAdmin)
            //    {
            //        Console.WriteLine("Hallo nicht Admin");
            //    }
            //}
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("Du bist eingeloggt");
            }

            Console.ReadKey();
        }
    }
}
