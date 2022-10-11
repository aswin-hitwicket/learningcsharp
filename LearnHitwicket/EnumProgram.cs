namespace LearnHitwicket
{
    enum Directions
    {
        NORTH, SOUTH, WEST, EAST
    }

    class Player
    {
        private Directions directions;

        public Player(Directions directions)
        {
            this.directions = directions;
        }

        public Directions GetDirection() { return this.directions; }
    }


    internal class EnumProgram
    {
        public static void EnumClassProgram()
        {
            var p = new Player(Directions.NORTH);
            Console.WriteLine(p.GetDirection());
        }
    }
}
