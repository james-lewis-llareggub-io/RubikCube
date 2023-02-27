namespace RubikCube.Contracts;

public interface IFaceTagHolder
{
    IEnumerable<FaceTag> Tags { get; }
    IFaceTagHolder Tag(FaceTag tag);
    bool Exists(FaceTag tag);
}