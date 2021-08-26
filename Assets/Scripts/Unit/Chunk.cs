using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk {
    public World world;
    public Vector2 postion;
    public Block[,] blocks;

    public Chunk(World world, Vector2 postion)
    {
        this.world = world;
        this.postion = postion;
        Block[,] blocks = new Block[16, 16];
        for(int x = 0; x < 16; x++)
        {

        }
    }

    public Chunk(World world, Vector2 postion, Block[,] blocks) : this(world, postion)
    {
        this.blocks = blocks;
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
