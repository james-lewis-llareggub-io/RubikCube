namespace RubikCube.Exceptions;

public class InvalidCubeMovementException : Exception
{
    public InvalidCubeMovementException(Vector3 move) : base($"x, y and z {move} exceed restricted values (-1, 0, 1)")
    {
    }
}