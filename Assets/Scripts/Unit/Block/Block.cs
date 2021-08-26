using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class Block
{
    [SerializeField]
    [ReadOnly]
    private int x;
    [SerializeField]
    [ReadOnly]
    private int y;
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

}
