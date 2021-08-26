using UnityEngine;
using NaughtyAttributes;

public class Block : MonoBehaviour
{
    private Location location;
    [SerializeField]
    [ReadOnly]
    private MaterialData material;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite[] variants;
    [SerializeField]
    [ReadOnly]
    private int curVariants;
    private Object perfeb;
    private bool isplaced;

    public Block(MaterialData material, Location location)
    {
        this.material = material;
        this.location = location;
        isplaced = false;
    }

    public void Place()
    {
        if (!isplaced)
        {
            World.SetBlock(this, location);
        }
        else
        {
            UnityLogger.PrintStackTrace("The block is already placed!");
        }
    }

    public void RemoveObject()
    {
        if (isplaced)
        {
            Destroy(this);
        }
        else
        {
            UnityLogger.PrintStackTrace("The block is not placed!");
        }
    }
}
