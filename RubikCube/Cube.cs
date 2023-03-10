namespace RubikCube;

public class Cube : ICube
{
    public Cube(IFaceTagHolder faceTagHolder) : this(faceTagHolder, 0, 0, 0)
    {
    }

    public Cube(IFaceTagHolder faceTagHolder, int x, int y, int z)
    {
        Location = new Vector3(x, y, z);
        FaceTagHolder = faceTagHolder;
    }

    public Vector3 Location { get; private set; }

    public IFaceTagHolder FaceTagHolder { get; }

    public void Move(Vector3 position)
    {
        if (OutOfBounds(position.X) || OutOfBounds(position.Y) || OutOfBounds(position.Z))
            throw new InvalidCubeMovementException(position);

        Location = position;
    }

    private bool OutOfBounds(float input)
    {
        return Enumerable.Range(-1, 3).Contains((int)input) == false;
    }
}