using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class Block : MonoBehaviour
{
    [SerializeField]
    [ReadOnly]
    private Vector2 postion;
    [SerializeField]
    [ReadOnly]
    private Material material;
    [SerializeField]
    private SpriteRenderer renderer;
    [SerializeField]
    private Sprite[] variants;
    [SerializeField]
    [ReadOnly]
    private int curVariants;

    public Block(Material material, Vector2 postion)
    {
        
    }
}
