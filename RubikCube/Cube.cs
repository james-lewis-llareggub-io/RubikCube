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
        Location = position;
    }
}