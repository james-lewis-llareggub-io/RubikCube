﻿namespace RubikCube;

public class FaceTagHolder : IFaceTagHolder
{
    private readonly List<FaceTag> _tags;

    public FaceTagHolder()
    {
        _tags = new List<FaceTag>();
    }

    public IFaceTagHolder Tag(FaceTag tag)
    {
        if (Exists(tag))
            _tags.Remove(tag);
        _tags.Add(tag);

        return this;
    }

    public bool Exists(FaceTag tag)
    {
        return _tags.Any(x => x.Face == tag.Face);
    }

    public IEnumerable<FaceTag> Tags => _tags;
}