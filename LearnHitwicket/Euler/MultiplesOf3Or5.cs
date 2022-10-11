namespace LearnHitwicket.Euler
{
    internal class MultiplesOf3Or5
    {
        private static int limit = 1000;

        public static void MainMultiplesOf3Or5()
        {
            int sum = 0;

            for(int i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
