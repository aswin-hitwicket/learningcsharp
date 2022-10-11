namespace LearnHitwicket
{
    internal class GridPlay
    {
        internal static void GridPlayProgram(int width, int height)
        {
            int[,] grid = new int[width, height];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + i != grid.Length - 1 ? ", " : "");
                }
                Console.WriteLine();
            }
        }
    }
}
