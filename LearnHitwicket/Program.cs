using System;

namespace Hitwicket
{
    public class Hitwicket
    {
        private static void PrintEvenNumbersAsTableProgram()
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

        private static void GetAgeAndValidate()
        {
            Console.Write("Your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is " + age);

            if (age > 18)
            {
                Console.WriteLine("Eligible!");
            }
            else
            {
                Console.WriteLine("Not Eligible!");
            }
        }

        private static void GetAgeAndValidateViaSwitch()
        {
            Console.Write("Your age:");
            uint age = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Your age is " + age);
            switch (age)
            {
                case 0:
                    Console.WriteLine("Invalid age! (>0)");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            PrintEvenNumbersAsTableProgram();
            GetAgeAndValidate();
            GetAgeAndValidateViaSwitch();

            Console.ReadKey();
        }
    }
}
