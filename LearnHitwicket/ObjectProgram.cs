namespace LearnHitwicket
{
    class Animal
    {
        int age;
        string name = "hiii";

        public string GetName() { return name; }
    }
    internal class ObjectProgram
    {
        public static void AnimalProgram()
        {
            var obj = new Animal();
            Console.WriteLine(obj.GetName());
        }
    }
}
