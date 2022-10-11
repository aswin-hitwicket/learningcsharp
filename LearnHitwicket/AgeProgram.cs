namespace LearnHitwicket
{
    internal class AgeProgram
    {
        internal static void GetAgeAndValidate()
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

        internal static void GetAgeAndValidateViaSwitch()
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
    }
}
