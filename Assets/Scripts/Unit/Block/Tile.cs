using UnityEngine;
using System.Collections;
using NaughtyAttributes;

public class Tile : MonoBehaviour
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
}
