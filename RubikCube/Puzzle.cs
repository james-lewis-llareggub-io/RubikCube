namespace RubikCube;

public class Puzzle
{
    private readonly List<Cube> _cubes;

    public Puzzle()
    {
        Width = Height = Depth = 3;
        _cubes = new List<Cube>();
        for (var z = 1; z > -2; z--)
        for (var y = -1; y < 2; y++)
        for (var x = -1; x < 2; x++)
            _cubes.Add(new Cube(x, y, z));
    }

    public int Width { get; }
    public int Height { get; }
    public int Depth { get; }

    public IEnumerable<Cube> Cubes => _cubes;
}