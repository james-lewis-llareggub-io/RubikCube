namespace RubikCube;

public readonly struct FaceTag
{
    public Face Face { get; }
    public FacePosition Position { get; }

    public FaceTag(Face face, FacePosition position)
    {
        Face = face;
        Position = position;
    }

    public override string ToString()
    {
        return $"{(char)Face}{(int)Position}";
    }
}