using UnityEngine;
using System.Collections;
using NaughtyAttributes;

public class GridManager : MonoBehaviour
{
    public static void SetupGrid(World world, Vector2 location)
    {
        GameObject TilePrefab = GameManager.GetAdapter().Tile_PreFab;
        GameObject o;
        Tile tile;
        o = Instantiate(TilePrefab);
        tile = o.GetComponent<Tile>();
    }

    public static void SetTile(Tile tile, Block block)
    {
        
    }
}
