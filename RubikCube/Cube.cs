namespace RubikCube;

public class Cube
{
    public Cube()
    {
        Location = new Vector3();
    }

    public Vector3 Location { get; private set; }

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