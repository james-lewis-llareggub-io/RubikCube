namespace RubikCube.Contracts;

public interface IPuzzle
{
    int Width { get; }
    int Height { get; }
    int Depth { get; }
    IEnumerable<ICube> Cubes { get; }
}