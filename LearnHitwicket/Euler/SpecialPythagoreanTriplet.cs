namespace LearnHitwicket.Euler
{
    internal class SpecialPythagoreanTriplet
    {
        public static void SpecialPythagoreanTripletMain()
        {
            /*
             * My appoarch. 
             * 
             * a + b + c = D
             * a < D / 3
             * b < D / 2
             * c < a < b
             */
            int D = 1000;
            for (int a = 1; a < D / 3; a++)
            {
                for (int b = a; b < D / 2; b++)
                {
                    int c = D - a - b;

                    if (MathF.Pow(a, 2) + MathF.Pow(b, 2) == MathF.Pow(c, 2))
                    {
                        Console.WriteLine(a * b * c);
                        break;
                    }
                }
            }
        }
    }
}
