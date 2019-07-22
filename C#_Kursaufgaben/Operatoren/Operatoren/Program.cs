using System;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // Unäre Operaotren
            num3 = -num1;
            Console.WriteLine("num3 ist {0}", num3);


            bool isSunny = true;
            Console.WriteLine("Ist es sonnig? {0}", !isSunny);

            // Die Inkrementoperatoren
            int num = 0;
            num++;
            Console.WriteLine("Num ist {0}", num);
            Console.WriteLine("Num ist {0}", num++);

            // Pre Increment
            Console.WriteLine("Num ist {0}", ++num);

            // Decrement Operator
            num--;
            Console.WriteLine("Num ist {0}", num);
            Console.WriteLine("Num ist {0}", num--);

            // Pre Decrement
            Console.WriteLine("Num ist {0}", --num);

            // -- Grundrechenarten --

            int result;
            // Addition
            result = num1 + num2;
            Console.WriteLine("Ergebnis von num1: {0} + num2: {1} ist {2}", num1, num2, result);
            // Subtraktion
            result = num1 - num2;
            Console.WriteLine("Ergebnis von num1: {0} - num2: {1} ist {2}", num1, num2, result);
            // Multiplikation
            result = num1 * num2;
            Console.WriteLine("Ergebnis von num1: {0} * num2: {1} ist {2}", num1, num2, result);
            // Division
            result = num1 / num2;
            Console.WriteLine("Ergebnis von num1: {0} / num2: {1} ist {2}", num1, num2, result);
            // Modulu
            result = num1 % num2;
            Console.WriteLine("Ergebnis von num1: {0} % num2: {1} ist {2}", num1, num2, result);


            // Relationale- und Typoperatoren
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Ergebnis von num1: {0} < num2: {1} ist {2}", num1, num2, isLower);


            // Gleicheit
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Ergebnis von num1: {0} == num2: {1} ist {2}", num1, num2, isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Ergebnis von num1: {0} != num2: {1} ist {2}", num1, num2, isEqual);


            // Traditionelle Operatoren
            bool isLowerAndSunny;
            //Konditional1 UND Konditional2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Ergebnis von num1: {0} && num2: {1} ist {2}", num1, num2, isLowerAndSunny);
            //Konditional1 ODER Konditional2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Ergebnis von num1: {0} || num2: {1} ist {2}", num1, num2, isLowerAndSunny);



            Console.ReadKey();
        }
    }
}
