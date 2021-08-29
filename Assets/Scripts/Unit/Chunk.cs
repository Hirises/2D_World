using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk {
    public World world;
    public Vector2 postion;
    public Block[,] blocks;
    private bool isload;

    public Chunk(World world, Vector2 postion)
    {
        this.world = world;
        this.postion = postion;
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

    public Chunk(World world, Vector2 postion, Block[,] blocks) : this(world, postion)
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
        if (!postion.Equals(target.postion)) { return false; }

        return true;
    }

    public override string ToString()
    {
        return world.ToString() + ' ' + postion.x + " ," + postion.y;
    }
}
