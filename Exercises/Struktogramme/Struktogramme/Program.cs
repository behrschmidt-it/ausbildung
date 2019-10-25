using System;

namespace Struktogramme
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int SucheMaximum(int[] liste)
        {
            int max = liste[0];
            for (int i = 0; i <= liste.Length - 1; i++)
            {
                if (liste[i] > max)
                {
                    max = liste[i];
                }
            }
            return max;
        }

        public static int SucheMaximumIndex(int[] liste)
        {
            int maxIndex = 0;
            for (int i = 0; i <= liste.Length - 1; i++)
            {
                if (liste[i] > liste[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public static int IndexWert(int[] liste, int wert)
        {
            int anzahl = liste.Length;
            bool gefunden = false;
            int index = 0;
            while (index < anzahl && gefunden == false)
            {
                if (liste[index] == wert)
                {
                    gefunden = true;
                }
                else
                {
                    index += 1;
                }
            }
            if (gefunden)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}
