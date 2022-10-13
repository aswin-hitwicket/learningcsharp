using System.Numerics;

namespace LearnHitwicket.Euler;

public class PowerDigitSum
{
    public static void PowerDigitSumProgram()
    {
        var number = BigInteger.Pow(2, 1000);

        Console.WriteLine(number.ToString().ToCharArray().Select((c, i) => Int32.Parse($"{c}")).Sum());
    }
}