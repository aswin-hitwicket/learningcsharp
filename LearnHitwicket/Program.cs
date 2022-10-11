using System;

namespace Hitwicket
{
    public class Hitwicket
    {
        public static void Main(string[] args)
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

            Console.Write("Your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            Random random = new Random();

            var randomAdder = random.Next(1, 5);
            Console.WriteLine(randomAdder);

            age = randomAdder + age;
            Console.WriteLine("Your random age is " + age);

            if (age > 18)
            {
                Console.WriteLine("Eligible!");
            }
            else
            {
                Console.WriteLine("Not Eligible!");
            }

            switch (age)
            {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    break;
            }

            Console.ReadKey();
        }
    }
}
