using System;

namespace MethodenMitRueckgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Multiply(32,55));
            Console.WriteLine(Devide(8, 2));
            Console.WriteLine(Add(Add(1, 2), Add(4, 5)));
            Console.WriteLine(Add(15, 23));
            
            Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            //return num1 * num2;

            int result = num1 * num2;
            return result;
        }

        public static double Devide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
