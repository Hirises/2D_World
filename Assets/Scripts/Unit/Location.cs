using UnityEngine;

public class Location
{
    public World world;
    public Chunk chunk;
    private Vector2 _localPostion;
    #region - Local and World Postion Getter and Setter
    public Vector2 localPostion
    {
        get
        {
            return _localPostion;
        }
        set
        {
            value.x = Mathf.Max(0, value.x);
            value.x = Mathf.Min(15, value.x);
            value.y= Mathf.Max(0, value.y);
            value.y = Mathf.Min(15, value.y);
            _localPostion = value;
        }

    }
    public Vector2 worldPostion
    {
        get
        {
            return ToWorldLocation(this);
        }
        set
        {
            _localPostion = ToLocalLocation(value);
        }

    }
    public float localX
    {
        get
        {
            return localPostion.x;
        }
        set
        {
            value = Mathf.Max(0, value);
            value = Mathf.Min(15, value);
            _localPostion.x = value;
        }
    }
    public float localY
    {
        get
        {
            return localPostion.y;
        }
        set
        {
            value = Mathf.Max(0, value);
            value = Mathf.Min(15, value);
            _localPostion.y = value;
        }
    }
    public float worldX
    {
        get
        {
            return worldPostion.x;
        }
        set
        {
            localPostion = ToLocalLocation(new Vector2(value, worldY));
        }
    }
    public float worldY
    {
        get
        {
            return worldPostion.y;
        }
        set
        {
            localPostion = ToLocalLocation(new Vector2(worldX, value));
        }
    }
    #endregion

    #region - Constructors
    public Location(World world, float worldX, float worldY) : this(world, world.GetChunkAt(worldX, worldY), worldX, worldY)
    {

    }

    public Location(World world, Vector2 worldPostion) : this(world, worldPostion.x, worldPostion.y)
    {

    }

    public Location(World world, Chunk chunk, Vector2 localPostion) : this(world, chunk, localPostion.x, localPostion.y)
    {

    }

    public Location(World world, Chunk chunk, float localX, float localY)
    {
        this.world = world;
        this.chunk = chunk;
        this.localPostion = new Vector2(localX, localY);
    }
    #endregion

    #region - Static Methods
    public static Vector2 ToWorldLocation(Location location)
    {
        return new Vector2((Settings.Block_Per_Chunk * location.chunk.x) + location.localX, (Settings.Block_Per_Chunk * location.chunk.y) + location.localY);
    }

    public static Vector2 ToLocalLocation(Vector2 worldLocation)
    {
        return new Vector2(Mathf.FloorToInt(worldLocation.x) / Settings.Block_Per_Chunk, Mathf.FloorToInt(worldLocation.y) / Settings.Block_Per_Chunk);
    }
    #endregion



    #region - Overrided Methods
    public override bool Equals(object obj)
    {
        Location target = (Location)obj;

        if (!world.Equals(target.world)) { return false; }
        if (!chunk.Equals(target.chunk)) { return false; }
        if (!localPostion.Equals(target.localPostion)) { return false; }

        return true;
    }

    public override string ToString()
    {
        return world.ToString() + ' ' + localPostion.x + ", " + localPostion.y + '(' + chunk.worldPostion.x +" ," + chunk.worldPostion.y + ')';
    }
    #endregion
}