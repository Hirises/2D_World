using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static Dictionary<string, World> worlds;
    private static Player player;

    public static World GetWorld(string name)
    {
        worlds.TryGetValue(name, out World output);
        return output;
    }

    public static bool AddWorld(string name, World world)
    {
        if (worlds.ContainsKey(name)) { return false; }
        worlds.Add(name, world);
        return true;
    }

    public static bool RemoveWorld(string name)
    {
        if(!worlds.ContainsKey(name)) { return false; }
        worlds.Remove(name);
        return true;
    }

    public static bool RemoveWorld(World world)
    {
        if (!worlds.ContainsValue(world)) { return false; }
        worlds.Remove(world.GetName());
        return true;
    }

    public static Player GetPlayer()
    {
        return player;
    }
}
