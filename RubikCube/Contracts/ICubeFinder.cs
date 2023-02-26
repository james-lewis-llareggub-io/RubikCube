namespace RubikCube.Contracts;

public interface ICubeFinder
{
    public IEnumerable<Cube> Find(IEnumerable<Cube> cubes, Face face);
}