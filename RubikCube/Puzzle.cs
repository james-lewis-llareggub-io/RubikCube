namespace RubikCube;

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