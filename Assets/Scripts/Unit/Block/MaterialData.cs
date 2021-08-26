using UnityEngine;
using System.Collections;

public class MaterialData : MonoBehaviour
{
    Material material;
    int data;

    public MaterialData(Material material, int data)
    {
        this.material = material;
        this.data = data;
    }
}
