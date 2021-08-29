using UnityEngine;
using System.Collections;

public class TestWorldGenerater : IWorldGenerater
{
    void IWorldGenerater.Generate(World world, Chunk chunk)
    {
        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 16; y++)
            {
                chunk.SetBlock(new Block(new MaterialData(Material.None, 0), new Location(world, chunk, new Vector2(x, y))), new Vector2(x, y));
            }
        }
    }
}
