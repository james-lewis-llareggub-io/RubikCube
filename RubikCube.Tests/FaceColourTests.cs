namespace RubikCube.Tests;

public class FaceColourTests
{
    public static IEnumerable<object[]> Colors
    {
        get
        {
            yield return new object[] { new KeyValuePair<Face, ConsoleColor>(Face.Back, ConsoleColor.Blue) };
            yield return new object[] { new KeyValuePair<Face, ConsoleColor>(Face.Front, ConsoleColor.Green) };
            yield return new object[] { new KeyValuePair<Face, ConsoleColor>(Face.Up, ConsoleColor.White) };
            yield return new object[] { new KeyValuePair<Face, ConsoleColor>(Face.Down, ConsoleColor.Yellow) };
            yield return new object[] { new KeyValuePair<Face, ConsoleColor>(Face.Left, ConsoleColor.Magenta) };
            yield return new object[] { new KeyValuePair<Face, ConsoleColor>(Face.Right, ConsoleColor.Red) };
        }
    }

    [Theory]
    [MemberData(nameof(Colors))]
    private void Test(KeyValuePair<Face, ConsoleColor> pair)
    {
        var picker = new FaceColour();
        picker.Pick(pair.Key).Should().Be(pair.Value);
    }
}