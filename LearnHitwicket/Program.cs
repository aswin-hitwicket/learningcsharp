using System;

using static LearnHitwicket.LearnArrays;
using static LearnHitwicket.AgeProgram;
using static LearnHitwicket.EvenTableProgram;

namespace Hitwicket
{
    public class Hitwicket
    {
        public static void Main(string[] args)
        {
            PrintEvenNumbersAsTableProgram();
            GetAgeAndValidate();
            GetAgeAndValidateViaSwitch();

            LearnArray();

            Console.ReadKey();
        }
    }
}
