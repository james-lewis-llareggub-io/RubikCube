namespace RubikCube.Tests;

public class FaceTagHolderTests
{
    private readonly FaceFaceTagHolder _faceFaceTagHolder;
    private readonly FaceTag _tag;

    protected FaceTagHolderTests()
    {
        _faceFaceTagHolder = new FaceFaceTagHolder();
        _tag = new FaceTag(Face.Back, FacePosition.One);
    }

    public class Exists : FaceTagHolderTests
    {
        [Fact]
        public void Exists_does_not_return_null()
        {
            var exists = _faceFaceTagHolder.Exists(_tag);
            exists.Should().BeFalse();
        }

        [Fact]
        public void Exists_returns_true_after_add_tag()
        {
            _faceFaceTagHolder.Tag(_tag);
            _faceFaceTagHolder.Exists(_tag).Should().BeTrue();
        }
    }

    public class Builder : FaceTagHolderTests
    {
        [Fact]
        public void Tag_returns_this()
        {
            _faceFaceTagHolder.Tag(_tag).Should().Be(_faceFaceTagHolder);
        }
    }

    public class FaceTags : FaceTagHolderTests
    {
        [Fact]
        public void Is_initially_empty()
        {
            _faceFaceTagHolder.Tags.Any().Should().BeFalse();
        }

        [Fact]
        public void Returns_count_of_one_after_add_tag()
        {
            _faceFaceTagHolder.Tag(_tag);
            _faceFaceTagHolder.Tags.Count().Should().Be(1);
        }
    }
}