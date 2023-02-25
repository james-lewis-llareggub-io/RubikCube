namespace RubikCube.Tests;

public class PuzzleTests
{
    private readonly Puzzle _puzzle;

    public PuzzleTests()
    {
        _puzzle = new Puzzle();
    }

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

public class Puzzle
{
    public Puzzle()
    {
        Width = Height = Depth = 3;
    }

    public int Width { get; }
    public int Height { get; }
    public int Depth { get; }
}