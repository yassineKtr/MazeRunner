using Xunit;

namespace MazeRunner.Tests
{
    public class RunnerTests
    {
        [Fact]
        public void ShouldBeAbleToFindStartCoordinations()
        {
            var maze = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 3 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 0, 0, 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 2, 1, 0, 1, 0, 1}
            };
            var sol = Runner.FindStartCords(maze);
            Assert.Equal(sol, new int[] { 6, 1 });
        }

        [Fact]
        public void ShouldBeAbleToGetValuesOfAPlaceInMaze()
        {
            var maze = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 3 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 0, 0, 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 2, 1, 0, 1, 0, 1}
            };
            var sol = Runner.GetValue(new int[] {1,6},maze);
            Assert.Equal(3, sol);
        }
        
        [Fact]
        public void ShouldBeAbleToFinishMaze()
        {
            var maze = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 3 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 0, 0, 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 2, 1, 0, 1, 0, 1}
            };
            var directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" };
            var sol = Runner.Run(maze, directions);
            Assert.Equal("Finish", sol);
        }
        
        [Fact]
        public void ShouldReturnLostIfItDoesntFindFinishLine()
        {
            var maze = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 3 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 0, 0, 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 2, 1, 0, 1, 0, 1}
            };
            var directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "S", "S", "S" };
            var sol = Runner.Run(maze, directions);
            Assert.Equal("Lost", sol);
        }

        [Fact]
        public void ShouldReturnDeadIfItHitsAWall()
        {
            var maze = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 3 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 0, 0, 1, 0, 0, 0, 1 },
                new int[] { 1, 0, 1, 0, 1, 0, 1 },
                new int[] { 1, 0, 0, 0, 0, 0, 1 },
                new int[] { 1, 2, 1, 0, 1, 0, 1}
            };
            var directions = new string[] { "N", "N", "N", "N", "E" };
            var sol = Runner.Run(maze, directions);
            Assert.Equal("Dead", sol);
        }
    }
}
