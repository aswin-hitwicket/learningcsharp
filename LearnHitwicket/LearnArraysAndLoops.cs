using System;

namespace LearnHitwicket
{
    internal class LearnArraysAndLoops
    {
        private static int[] array = new int[10];

        private static string GetFormattedString(int i)
        {
            return array[i] + (i != array.Length - 1 ? ", " : "");
        }

        internal static void LearnArray()
        {

            array[0] = -1;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(GetFormattedString(i));
            }
            Console.WriteLine();

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}

