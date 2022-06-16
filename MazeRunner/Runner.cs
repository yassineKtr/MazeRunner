namespace MazeRunner
{
    public  class Runner
    {
        public static Dictionary<string,int[]> Directions = new ()
        {
            { "N", new int[] { -1 , 0 } },
            { "S", new int[] { 1 , 0 } },
            { "E", new int[] { 0 , 1 } },
            { "W", new int[] { 0 , -1 } }
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
            var currentPos = FindStartCords(maze);
            var i = 0;
            while (i<solution.Length)
            {
                currentPos = new int[] { currentPos[0] + Directions[solution[i]][0], currentPos[1] + +Directions[solution[i]][1] };
                var currentPoint = GetValue(currentPos, maze);
                if (currentPoint == 1) return "Dead";
                if (currentPoint == 3) return "Finish";
                i++;
            }
            return "Lost";
        }
    }
}
