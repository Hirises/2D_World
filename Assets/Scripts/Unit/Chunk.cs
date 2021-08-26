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
        //TODO blocks √ ±‚»≠
    }

    public Chunk(World world, Vector2 postion, Block[,] blocks) : this(world, postion)
    {
        this.blocks = blocks;
    }

    public void SetBlock(Block block, Location location)
    {
        int x = (int)Mathf.Round(location.postion.x);
        int y = (int)Mathf.Round(location.postion.y);
        if (isload)
        {
            Block previous = blocks[x, y];
            previous
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
