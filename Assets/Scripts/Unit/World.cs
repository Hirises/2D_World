using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    private string worldName;
    private Dictionary<Pair<int, int>, Chunk> chunks;

    public World(string name)
    {
        this.worldName = name;
        chunks = new Dictionary<Pair<int, int>, Chunk>();
    }

    public string GetName()
    {
        return worldName;
    }

    public static void SetBlock(Block block, Location location)
    {
        location.chunk.SetBlock(block, location);
    }

    public override bool Equals(object other)
    {
        World target = (World)other;
        return worldName.Equals(target.worldName);
    }

    public override string ToString()
    {
        return worldName;
    }
}
