namespace RubikCube.Tests;

public class FaceTagTests
{
    [Theory]
    [InlineData(Face.Up, FacePosition.One, "U1")]
    [InlineData(Face.Up, FacePosition.Two, "U2")]
    [InlineData(Face.Up, FacePosition.Three, "U3")]
    [InlineData(Face.Up, FacePosition.Four, "U4")]
    [InlineData(Face.Up, FacePosition.Five, "U5")]
    [InlineData(Face.Up, FacePosition.Six, "U6")]
    [InlineData(Face.Up, FacePosition.Seven, "U7")]
    [InlineData(Face.Up, FacePosition.Eight, "U8")]
    [InlineData(Face.Up, FacePosition.Nine, "U9")]
    public void FaceTag_toString_matches_expectations(
        Face face,
        FacePosition position,
        string label
    )
    {
        var tag = new FaceTag(face, position);
        tag.ToString().Should().Be(label);
    }

    [Theory]
    [InlineData(Face.Up, FacePosition.One)]
    [InlineData(Face.Up, FacePosition.Two)]
    [InlineData(Face.Up, FacePosition.Three)]
    [InlineData(Face.Up, FacePosition.Four)]
    [InlineData(Face.Up, FacePosition.Five)]
    [InlineData(Face.Up, FacePosition.Six)]
    [InlineData(Face.Up, FacePosition.Seven)]
    [InlineData(Face.Up, FacePosition.Eight)]
    [InlineData(Face.Up, FacePosition.Nine)]
    public void FaceTag_sets_values_as_expected(
        Face face,
        FacePosition position
    )
    {
        var tag = new FaceTag(face, position);
        tag.Face.Should().Be(face);
        tag.Position.Should().Be(position);
    }
}