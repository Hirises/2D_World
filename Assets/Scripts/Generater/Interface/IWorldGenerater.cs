using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWorldGenerater
{
    void Generate(World world, Chunk chunk);
}
