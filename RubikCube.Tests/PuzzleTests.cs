namespace RubikCube.Tests;

public class PuzzleTests
{
    private readonly Puzzle _puzzle;

    protected PuzzleTests()
    {
        _puzzle = new Puzzle();
    }

    public class DimensionTests : PuzzleTests
    {
        [Fact]
        public void PuzzleHasWidthOfThree()
        {
            _puzzle.Width.Should().Be(3);
        }

        [Fact]
        public void PuzzleHasHeightOfThree()
        {
            _puzzle.Height.Should().Be(3);
        }

        [Fact]
        public void PuzzleHasDepthOfThree()
        {
            _puzzle.Depth.Should().Be(3);
        }
    }


    public class AssignmentTests : PuzzleTests
    {
        [Fact]
        public void Puzzle_has_27_cubes()
        {
            _puzzle.Cubes.Should().NotBeNull();
            _puzzle.Cubes.Count().Should().Be(27);
        }

        [Theory]
        [InlineData(1, -1, -1, 1)]
        [InlineData(2, 0, -1, 1)]
        [InlineData(3, 1, -1, 1)]
        [InlineData(4, -1, 0, 1)]
        [InlineData(5, 0, 0, 1)]
        [InlineData(6, 1, 0, 1)]
        [InlineData(7, -1, 1, 1)]
        [InlineData(8, 0, 1, 1)]
        [InlineData(9, 1, 1, 1)]
        public void Puzzle_has_assigned_cube_locations_correctly_1st_row(int index, int x, int y, int z)
        {
            var cube = _puzzle.Cubes.ToList()[index - 1];
            cube.Location.X.Should().Be(x + 400);
            cube.Location.Y.Should().Be(y + 400);
            cube.Location.Z.Should().Be(z + 400);
        }

        [Theory]
        [InlineData(10, -1, -1, 0)]
        [InlineData(11, 0, -1, 0)]
        [InlineData(12, 1, -1, 0)]
        [InlineData(13, -1, 0, 0)]
        [InlineData(14, 0, 0, 0)]
        [InlineData(15, 1, 0, 0)]
        [InlineData(16, -1, 1, 0)]
        [InlineData(17, 0, 1, 0)]
        [InlineData(18, 1, 1, 0)]
        public void Puzzle_has_assigned_cube_locations_correctly_2nd_row(int index, int x, int y, int z)
        {
            var cube = _puzzle.Cubes.ToList()[index - 1];
            cube.Location.X.Should().Be(x + 400);
            cube.Location.Y.Should().Be(y + 400);
            cube.Location.Z.Should().Be(z + 400);
        }

        [Theory]
        [InlineData(19, -1, -1, -1)]
        [InlineData(20, 0, -1, -1)]
        [InlineData(21, 1, -1, -1)]
        [InlineData(22, -1, 0, -1)]
        [InlineData(23, 0, 0, -1)]
        [InlineData(24, 1, 0, -1)]
        [InlineData(25, -1, 1, -1)]
        [InlineData(26, 0, 1, -1)]
        [InlineData(27, 1, 1, -1)]
        public void Puzzle_has_assigned_cube_locations_correctly_3rd_row(int index, int x, int y, int z)
        {
            var cube = _puzzle.Cubes.ToList()[index - 1];
            cube.Location.X.Should().Be(x + 400);
            cube.Location.Y.Should().Be(y + 400);
            cube.Location.Z.Should().Be(z + 400);
        }
    }
}