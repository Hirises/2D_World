using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    private string worldName;
    private Map<Pair<int, int>, Chunk> chunks = new Map<Pair<int, int>, Chunk>();
    private ArrayList Generater = new ArrayList();

    public World(string name)
    {
        this.worldName = name;
    }

    public string GetName()
    {
        return worldName;
    }

    public Chunk GetChunk(Pair<int, int> postion)
    {
        if (chunks.ContainKey(postion))
        {
            return chunks.Get(postion);
        }
        else
        {
            return LoadChunk(postion);
        }
    }

    public Chunk LoadChunk(Pair<int, int> postion)
    {
        Chunk chunk = new Chunk(this, new Vector2(postion.x, postion.y));
        foreach (IWorldGenerater generater in Generater)
        {
            generater.Generate(this, chunk);
        }
        chunk.EndLoad();
        chunks.Put(postion, chunk);
        return chunk;
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
