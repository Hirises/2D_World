using UnityEngine;

public class Location
{
    public World world;
    public Chunk chunk;
    public Vector2 postion;

    public Location(World world, Chunk chunk, Vector2 postion)
    {
        this.world = world;
        this.chunk = chunk;
        this.postion = postion;
    }

    public override bool Equals(object obj)
    {
        Location target = (Location)obj;

        if (!world.Equals(target.world)) { return false; }
        if (!chunk.Equals(target.chunk)) { return false; }
        if (!postion.Equals(target.postion)) { return false; }

        return true;
    }

    public override string ToString()
    {
        return world.ToString() + ' ' + postion.x + ", " + postion.y + '(' + chunk.postion.x +" ," + chunk.postion.y + ')';
    }
}