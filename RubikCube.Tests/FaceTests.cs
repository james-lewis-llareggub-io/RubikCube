namespace RubikCube.Tests;

public class FaceTests
{
    [Theory]
    [InlineData(Face.Front, 'F')]
    [InlineData(Face.Back, 'B')]
    [InlineData(Face.Left, 'L')]
    [InlineData(Face.Right, 'R')]
    [InlineData(Face.Up, 'U')]
    [InlineData(Face.Down, 'D')]
    public void Face_keys_match(Face face, char character)
    {
        ((char)face).Should().Be(character);
    }
}