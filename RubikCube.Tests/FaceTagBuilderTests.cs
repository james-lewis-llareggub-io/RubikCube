namespace RubikCube.Tests;

public class FaceTagBuilderTests
{
    private readonly ICubeFinder _cubeFinder;
    private readonly IPuzzle _puzzle;

    public FaceTagBuilderTests()
    {
        _puzzle = new Puzzle();
        _cubeFinder = new CubeFinder();
    }

    [Theory]
    [InlineData(Face.Front)]
    [InlineData(Face.Back)]
    [InlineData(Face.Left)]
    [InlineData(Face.Right)]
    [InlineData(Face.Up)]
    [InlineData(Face.Down)]
    public void Puzzle_contains_9_positions_for_each_face(Face face)
    {
        var faceTagBuilder = new FaceTagBuilder();
        faceTagBuilder.Build(_puzzle, _cubeFinder);
        var list = new List<FaceTag>();
        var position = 0;
        foreach (var cube in _puzzle.Cubes)
        foreach (var tag in cube.FaceTagHolder.Tags)
            if (tag.Face == face)
            {
                list.Add(tag);
                ((int)tag.Position).Should().Be(++position);
            }

        list.Count.Should().Be(9);
    }
}