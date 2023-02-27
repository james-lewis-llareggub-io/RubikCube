namespace RubikCube;

public class CubeFinder : ICubeFinder
{
    public IEnumerable<ICube> Find(IEnumerable<ICube> cubes, Face face)
    {
        return face switch
        {
            Face.Front => cubes.Where(x => (int)x.Location.Z == 1).ToList(),
            Face.Back => cubes.Where(x => (int)x.Location.Z == -1).ToList(),
            Face.Right => cubes.Where(x => (int)x.Location.X == 1).ToList(),
            Face.Left => cubes.Where(x => (int)x.Location.X == -1).ToList(),
            Face.Down => cubes.Where(x => (int)x.Location.Y == 1).ToList(),
            Face.Up => cubes.Where(x => (int)x.Location.Y == -1).ToList(),
            _ => new List<ICube>()
        };
    }
}