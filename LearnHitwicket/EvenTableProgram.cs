namespace LearnHitwicket
{
    internal class EvenTableProgram
    {
        internal static void PrintEvenNumbersAsTableProgram()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
