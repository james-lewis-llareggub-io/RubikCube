﻿namespace RubikCube.Contracts;

public interface ICube
{
    Vector3 Location { get; }
    void Move(Vector3 position);
}