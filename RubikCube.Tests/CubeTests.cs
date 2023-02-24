namespace RubikCube.Tests;

public class CubeTests
{
    private readonly Cube _cube;

    public CubeTests()
    {
        _cube = new Cube();
    }

    [Fact]
    public void Has_3D_initial_location_of_zero()
    {
        _cube.Location.X.Should().Be(0);
        _cube.Location.Y.Should().Be(0);
        _cube.Location.Z.Should().Be(0);
    }
}