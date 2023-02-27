namespace RubikCube.Contracts;

public interface ICubeFinder
{
    public IEnumerable<ICube> Find(IEnumerable<ICube> cubes, Face face);
}