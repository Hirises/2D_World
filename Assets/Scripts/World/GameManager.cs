using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static Map<string, World> worlds = new Map<string, World>();
    private static Player player;
    private static CameraController cameraController;
    private static Settings settings;

    private void Awake()
    {
        settings = new Settings();
        worlds.Put("OverWorld", new World("OverWorld"));
        World mainWorld = worlds.Get("OverWorld");
        player = new Player(mainWorld);
        cameraController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
        cameraController.SetTargetPlayer(player);
        for (int x = -4; x < 4; x++)
        {
            for (int y = -4; y < 4; y++)
            {
                mainWorld.LoadChunk(new Pair<int, int>(x, y));
            }
        }
        GridManager.SetupGrid(mainWorld, Vector2.zero);
    }

    public static Settings GetSettings()
    {
        return settings;
    }

    public static World GetWorld(string name)
    {
        return worlds.Get(name);
    }

    public static bool AddWorld(World world)
    {
        if (worlds.ContainKey(world.GetName())) { return false; }
        worlds.Put(world.GetName(), world);
        return true;
    }

    public static bool RemoveWorld(string name)
    {
        if(!worlds.ContainKey(name)) { return false; }
        worlds.RemoveKey(name);
        return true;
    }

    public static bool RemoveWorld(World world)
    {
        if (!worlds.ContainValue(world)) { return false; }
        worlds.RemoveKey(world.GetName());
        return true;
    }

    public static Player GetPlayer()
    {
        return player;
    }
}
