namespace LearnHitwicket.Euler
{
    internal class LargestPrimeFactor
    {
        public static void LargestPrimeFactorProgram()
        {
            long num = 13195;
            string answer = "";

            for(int i = 1; i < num; i++)
            {
                if (num % i == 0 && num % 1 == 0)
                {
                    answer += i + ", ";
                }
            }
            Console.WriteLine("The prime factor(s) include " + answer);
        }
    }
}
