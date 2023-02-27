namespace RubikCube;

public class FaceTagBuilder
{
    public IPuzzle Build(IPuzzle puzzle, ICubeFinder cubeFinder)
    {
        Build(puzzle, cubeFinder, Face.Front);
        Build(puzzle, cubeFinder, Face.Back);
        Build(puzzle, cubeFinder, Face.Left);
        Build(puzzle, cubeFinder, Face.Right);
        Build(puzzle, cubeFinder, Face.Up);
        Build(puzzle, cubeFinder, Face.Down);

        return puzzle;
    }

    private void Build(IPuzzle puzzle, ICubeFinder cubeFinder, Face face)
    {
        var cubes = cubeFinder.Find(puzzle.Cubes, face).ToList();
        for (var i = 0; i < cubes.Count; i++)
        {
            var cube = cubes[i];
            cube.FaceTagHolder.Tag(new FaceTag(face, (FacePosition)i + 1));
        }
    }
}