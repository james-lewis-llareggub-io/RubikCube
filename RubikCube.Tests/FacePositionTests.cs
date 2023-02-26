namespace RubikCube.Tests;

public class FacePositionTests
{
    [Theory]
    [InlineData(FacePosition.One, 1)]
    [InlineData(FacePosition.Two, 2)]
    [InlineData(FacePosition.Three, 3)]
    [InlineData(FacePosition.Four, 4)]
    [InlineData(FacePosition.Five, 5)]
    [InlineData(FacePosition.Six, 6)]
    [InlineData(FacePosition.Seven, 7)]
    [InlineData(FacePosition.Eight, 8)]
    [InlineData(FacePosition.Nine, 9)]
    public void Face_keys_match(FacePosition position, int number)
    {
        ((int)position).Should().Be(number);
    }
}