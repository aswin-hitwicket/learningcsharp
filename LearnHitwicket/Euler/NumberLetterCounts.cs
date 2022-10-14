namespace LearnHitwicket.Euler
{
    internal class NumberLetterCounts
    {
        static long OnXEven(long x) => x / 2;

        static long OnXOdd(long x) => (3 * x) + 1;

        static long NextX(long x) => (x % 2 == 0) ? OnXEven(x) : OnXOdd(x);

        static long CollatzSequence(long startingNumber)
        {
            var x = startingNumber;
            long count = 0;

            while (x != 1)
            {
                x = NextX(x);
                count++;
            }
            Console.WriteLine($"Collatz sequence for {startingNumber} is {count}");

            return count;
        }

        public static void NumberLetterCountsProgram()
        {
            const int limit = 1000000;
            var chainLengths = new List<long>();

            for (int i = 1; i <= limit; i++)
            {
                chainLengths.Add(CollatzSequence(i));
            }

            Console.WriteLine($"Largest collatz sequence is {chainLengths.Max()}");
        }
    }
}
