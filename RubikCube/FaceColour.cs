namespace RubikCube;

public class FaceColour
{
    public ConsoleColor Pick(Face face)
    {
        return face switch
        {
            Face.Front => ConsoleColor.Green,
            Face.Back => ConsoleColor.Blue,
            Face.Right => ConsoleColor.Red,
            Face.Left => ConsoleColor.Magenta,
            Face.Down => ConsoleColor.Yellow,
            Face.Up => ConsoleColor.White,
            _ => ConsoleColor.Black
        };
    }
}