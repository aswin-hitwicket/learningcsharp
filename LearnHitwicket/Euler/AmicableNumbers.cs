namespace LearnHitwicket.Euler {
    internal class AmicableNumbers {
        private const int LIMIT = 10000;

        public static void AmicableNumbersMain() {
            int sum = 0;
            int fact = 0;
            int fact2 = 0;

            for (int i = 2; i <= LIMIT; i++) {
                fact = FactorSum(i);
                if (fact > i) {
                    fact2 = FactorSum(fact);

                    if (fact2 == i) {
                        sum += i + fact;
                    }
                }
            }

            Console.WriteLine(sum);
        }

        private static int FactorSum(int n) {
            int sum = 1;
            int squared = (int)Math.Sqrt(n);

            if (n == squared * squared) {
                squared--;
                sum += squared;
            }

            for (int i = 2; i <= squared; i++) {
                if (n % i == 0) {
                    sum += i + (n / i);
                }
            }

            return sum;
        }
    }
}
