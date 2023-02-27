namespace RubikCube.Tests;

public class FaceTagHolderTests
{
    private readonly IFaceTagHolder _faceTagHolder;
    private readonly FaceTag _tag;

    protected FaceTagHolderTests()
    {
        _faceTagHolder = new FaceTagHolder();
        _tag = new FaceTag(Face.Back, FacePosition.One);
    }

    public class Exists : FaceTagHolderTests
    {
        [Fact]
        public void Exists_does_not_return_null()
        {
            var exists = _faceTagHolder.Exists(_tag);
            exists.Should().BeFalse();
        }

        [Fact]
        public void Exists_returns_true_after_add_tag()
        {
            _faceTagHolder.Tag(_tag);
            _faceTagHolder.Exists(_tag).Should().BeTrue();
        }
    }

    public class Builder : FaceTagHolderTests
    {
        [Fact]
        public void Tag_returns_this()
        {
            _faceTagHolder.Tag(_tag).Should().Be(_faceTagHolder);
        }
    }

    public class FaceTags : FaceTagHolderTests
    {
        [Fact]
        public void Is_initially_empty()
        {
            _faceTagHolder.Tags.Any().Should().BeFalse();
        }

        [Fact]
        public void Returns_count_of_one_after_add_tag()
        {
            _faceTagHolder.Tag(_tag);
            _faceTagHolder.Tags.Count().Should().Be(1);
        }
    }
}