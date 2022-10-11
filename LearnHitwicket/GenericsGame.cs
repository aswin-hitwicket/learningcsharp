using System.Collections.Generic;

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

            Dictionary<string, string> json = new Dictionary<string, string>(10);

            json.Add("hi", "value from hi");

            string? output;

            json.TryGetValue("hi", out output);

            Console.WriteLine(output);
        }
    }
}
