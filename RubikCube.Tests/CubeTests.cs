namespace RubikCube.Tests;

public class CubeTests
{
    private readonly ICube _cube;

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

    public class MoveTests : CubeTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 1)]
        [InlineData(-1, 0, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(0, 0, -1)]
        public void Move(int x, int y, int z)
        {
            var move = new Vector3(x, y, z);
            _cube.Move(move);
            _cube.Location.Should().Be(move);
        }

        [Theory]
        [InlineData(2, 0, 0)]
        [InlineData(0, 2, 0)]
        [InlineData(0, 0, 2)]
        public void IllegalMove(int x, int y, int z)
        {
            var move = new Vector3(x, y, z);
            _cube.Invoking(x => x.Move(move))
                .Should().Throw<InvalidCubeMovementException>()
                .WithMessage($"x, y and z {move} exceed restricted values (-1, 0, 1)");
        }
    }
}