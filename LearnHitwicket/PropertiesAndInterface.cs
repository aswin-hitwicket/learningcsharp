namespace LearnHitwicket
{
    interface IHasHealth
    {
        public float _health { get; set; }
    }
    class PlayerDefinition : IHasHealth
    {
        public float _health { get; set; }

        public float Health { get { return _health; } set { _health = value; } }
    }

    internal class PropertiesAndInterface
    {
        public static void PropertiesProgram()
        {
            var p = new PlayerDefinition();
            p.Health = 10;
            Console.WriteLine("Player health is " + p.Health);
        }
    }
}
