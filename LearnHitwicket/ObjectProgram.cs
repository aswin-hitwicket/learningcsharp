namespace LearnHitwicket
{
    class Animal
    {
        int age;
        string name;

        public Animal(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public string GetName() { return name; }
        public int GetAge() { return age; }
    }
    internal class ObjectProgram
    {
        public static void AnimalProgram()
        {
            var obj = new Animal(1, "f");
            Console.WriteLine(obj.GetName());
            Console.WriteLine(obj.GetAge());
        }
    }
}
