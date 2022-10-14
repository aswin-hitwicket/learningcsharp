using System.Numerics;

namespace LearnHitwicket.Euler
{
    internal class SelfPower
    {
        public static void SelfPowerMain()
        {
            var sum = new BigInteger();
            for (int i = 1; i <= 1000; i++)
            {
                sum += BigInteger.Pow(i, i);
            }

            var sumString = sum.ToString();
            var lastTenDigits = sumString.Substring(Math.Max(0, sumString.Length - 10));

            Console.WriteLine(lastTenDigits);
        }
    }
}
