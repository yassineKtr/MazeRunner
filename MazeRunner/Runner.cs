namespace MazeRunner
{
    public  class Runner
    {
        public static Dictionary<string,int[]> Directions = new Dictionary<string, int[]>()
        {
            { "N", new int[] { -1, 0 } },
            { "S", new int[] { 1 , 0 } },
            { "E", new int[] { 0, 1 } },
            { "W", new int[] { 0, -1 } }
        };
        public static int[] FindStartCords(int[][] maze)
        {
            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze[i].Length; j++)
                {
                    if (maze[i][j] == 2)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }
        public static int GetValue(int[] cords, int[][] maze) => maze[cords[0]][cords[1]];
        
        
        public static string Run(int[][] maze , string[] solution)
        {
            var startPointCord = FindStartCords(maze);
            var nextPoint = GetValue(new int[] { startPointCord[0] + Directions[solution[0]][0] , startPointCord[1] + +Directions[solution[0]][1] }, maze);
            
            return string.Empty;
        }
    }
}
