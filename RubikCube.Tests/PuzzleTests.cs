namespace RubikCube.Tests;

public class PuzzleTests
{
    [Fact]
    public void PuzzleHasWidthOfThree()
    {
        var puzzle = new Puzzle();
        puzzle.Width.Should().Be(3);
    }

    [Fact]
    public void PuzzleHasHeightOfThree()
    {
        var puzzle = new Puzzle();
        puzzle.Height.Should().Be(3);
    }


    [Fact]
    public void PuzzleHasDepthOfThree()
    {
        var puzzle = new Puzzle();
        puzzle.Depth.Should().Be(3);
    }
}

public class Puzzle
{
    public int Width { get; set; }

    public int Height { get; set; }

    public int Depth { get; set; }
}