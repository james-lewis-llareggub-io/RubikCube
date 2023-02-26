namespace RubikCube.Tests;

public class CubeFinderTests
{
    private readonly ICubeFinder _cubeFinder;
    private readonly Puzzle _puzzle;

    public CubeFinderTests()
    {
        _cubeFinder = new CubeFinder();
        _puzzle = new Puzzle();
    }

    [Theory]
    [InlineData(Face.Front)]
    [InlineData(Face.Back)]
    [InlineData(Face.Left)]
    [InlineData(Face.Right)]
    [InlineData(Face.Up)]
    [InlineData(Face.Down)]
    public void Each_face_should_return_9_cubes(Face face)
    {
        var found = _cubeFinder.Find(_puzzle.Cubes, face);
        found.Count().Should().Be(9);
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
    public void Front_should_return_9_correct_cubes(int index, int x, int y, int z)
    {
        var found = _cubeFinder.Find(_puzzle.Cubes, Face.Front);
        var cube = found.ToList()[index - 1];
        cube.Location.X.Should().Be(x);
        cube.Location.Y.Should().Be(y);
        cube.Location.Z.Should().Be(z);
    }

    [Theory]
    [InlineData(1, -1, -1, -1)]
    [InlineData(2, 0, -1, -1)]
    [InlineData(3, 1, -1, -1)]
    [InlineData(4, -1, 0, -1)]
    [InlineData(5, 0, 0, -1)]
    [InlineData(6, 1, 0, -1)]
    [InlineData(7, -1, 1, -1)]
    [InlineData(8, 0, 1, -1)]
    [InlineData(9, 1, 1, -1)]
    public void Back_should_return_9_correct_cubes(int index, int x, int y, int z)
    {
        var found = _cubeFinder.Find(_puzzle.Cubes, Face.Back);
        var cube = found.ToList()[index - 1];
        cube.Location.X.Should().Be(x);
        cube.Location.Y.Should().Be(y);
        cube.Location.Z.Should().Be(z);
    }

    [Theory]
    [InlineData(1, 1, -1, 1)]
    [InlineData(2, 1, 0, 1)]
    [InlineData(3, 1, 1, 1)]
    [InlineData(4, 1, -1, 0)]
    [InlineData(5, 1, 0, 0)]
    [InlineData(6, 1, 1, 0)]
    [InlineData(7, 1, -1, -1)]
    [InlineData(8, 1, 0, -1)]
    [InlineData(9, 1, 1, -1)]
    public void Right_should_return_9_correct_cubes(int index, int x, int y, int z)
    {
        var found = _cubeFinder.Find(_puzzle.Cubes, Face.Right);
        var cube = found.ToList()[index - 1];
        cube.Location.X.Should().Be(x);
        cube.Location.Y.Should().Be(y);
        cube.Location.Z.Should().Be(z);
    }

    [Theory]
    [InlineData(1, -1, -1, 1)]
    [InlineData(2, -1, 0, 1)]
    [InlineData(3, -1, 1, 1)]
    [InlineData(4, -1, -1, 0)]
    [InlineData(5, -1, 0, 0)]
    [InlineData(6, -1, 1, 0)]
    [InlineData(7, -1, -1, -1)]
    [InlineData(8, -1, 0, -1)]
    [InlineData(9, -1, 1, -1)]
    public void Left_should_return_9_correct_cubes(int index, int x, int y, int z)
    {
        var found = _cubeFinder.Find(_puzzle.Cubes, Face.Left);
        var cube = found.ToList()[index - 1];
        cube.Location.X.Should().Be(x);
        cube.Location.Y.Should().Be(y);
        cube.Location.Z.Should().Be(z);
    }

    [Theory]
    [InlineData(1, -1, 1, 1)]
    [InlineData(2, 0, 1, 1)]
    [InlineData(3, 1, 1, 1)]
    [InlineData(4, -1, 1, 0)]
    [InlineData(5, 0, 1, 0)]
    [InlineData(6, 1, 1, 0)]
    [InlineData(7, -1, 1, -1)]
    [InlineData(8, 0, 1, -1)]
    [InlineData(9, 1, 1, -1)]
    public void Down_should_return_9_correct_cubes(int index, int x, int y, int z)
    {
        var found = _cubeFinder.Find(_puzzle.Cubes, Face.Down);
        var cube = found.ToList()[index - 1];
        cube.Location.X.Should().Be(x);
        cube.Location.Y.Should().Be(y);
        cube.Location.Z.Should().Be(z);
    }

    [Theory]
    [InlineData(1, -1, -1, 1)]
    [InlineData(2, 0, -1, 1)]
    [InlineData(3, 1, -1, 1)]
    [InlineData(4, -1, -1, 0)]
    [InlineData(5, 0, -1, 0)]
    [InlineData(6, 1, -1, 0)]
    [InlineData(7, -1, -1, -1)]
    [InlineData(8, 0, -1, -1)]
    [InlineData(9, 1, -1, -1)]
    public void Up_should_return_9_correct_cubes(int index, int x, int y, int z)
    {
        var found = _cubeFinder.Find(_puzzle.Cubes, Face.Up);
        var cube = found.ToList()[index - 1];
        cube.Location.X.Should().Be(x);
        cube.Location.Y.Should().Be(y);
        cube.Location.Z.Should().Be(z);
    }
}