using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk {
    public World world;
    public Pair<int, int> worldPostion;
    public int x
    {
        get
        {
            return worldPostion.x;
        }
        set
        {
            worldPostion.x = value;
        }
    }
    public int y
    {
        get
        {
            return worldPostion.y;
        }
        set
        {
            worldPostion.y = value;
        }
    }
    public Block[,] blocks;
    private bool isload;

    public Chunk(World world, Pair<int, int> postion)
    {
        this.world = world;
        this.worldPostion = postion;
        isload = false;
        Block[,] blocks = new Block[16, 16];
        for(int x = 0; x < 16; x++)
        {
            for (int y = 0;  y< 16; y++)
            {
                blocks[x, y] = new Block(new MaterialData(Material.None, 0), new Location(world, this, new Vector2(x, y)));
            }
        }
    }

    public Chunk(World world, Pair<int, int> postion, Block[,] blocks) : this(world, postion)
    {
        this.blocks = blocks;
    }

    public void EndLoad()
    {
        isload = true;
    }

    public void SetBlock(Block block, Vector2 location)
    {
        int x = (int)Mathf.Round(location.x);
        int y = (int)Mathf.Round(location.y);
        if (isload)
        {
            Block previous = blocks[x, y];
        }
        blocks[x, y] = block;
    }

    public override bool Equals(object obj)
    {
        Chunk target = (Chunk)obj;

        if (!world.Equals(target.world)) { return false; }
        if (!worldPostion.Equals(target.worldPostion)) { return false; }

        return true;
    }

    public override string ToString()
    {
        return world.ToString() + ' ' + worldPostion.x + " ," + worldPostion.y;
    }
}
