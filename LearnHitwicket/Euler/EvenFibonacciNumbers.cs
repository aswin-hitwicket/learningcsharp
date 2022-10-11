using static System.Net.Mime.MediaTypeNames;

namespace LearnHitwicket.Euler
{
    internal class EvenFibonacciNumbers
    {
        private static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            int total = 0;
            int i = 0;
            while (i <= n)
            {
                total = a + b;
                a = b;
                b = total;
                i++;
            }
            return total;
        }

        public static void MainEvenFibonacciNumbers()
        {
            Console.Write(Fibonacci(5));

            int limit = 4_000_000;

            int sum = 0;

            int i = 2;

            int fib = Fibonacci(i);
            while (fib < limit)
            {
                if (fib % 2 == 0)
                {
                    sum += fib;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
