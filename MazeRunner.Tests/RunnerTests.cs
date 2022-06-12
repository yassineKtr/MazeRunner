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
    }
}
