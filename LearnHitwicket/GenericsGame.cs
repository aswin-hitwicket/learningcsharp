namespace LearnHitwicket
{
    class Container<T>
    {
        private readonly T _value;

        public Container(T data)
        {
            _value = data;
        }

        public T Value { get { return _value; } }

        public override string ToString() { return "Container(" + _value + ")"; }
    }

    internal class GenericsGame
    {
        public static void GenricGameProgram()
        {
            var container = new Container<uint>(0);
            Console.WriteLine(container);
        }
    }
}
