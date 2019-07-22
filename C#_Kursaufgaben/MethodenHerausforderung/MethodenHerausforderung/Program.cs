using System;

namespace MethodenHerausforderung
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "David";
            string friend3 = "Marvin";

            GreetFriend(friend1, friend2, friend3);
            Console.ReadKey();
        }

        public static void GreetFriend(string friendName, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi {0}, {1} und {2} meine Freunde!", friendName, friendName2, friendName3);
        }

    }
}
