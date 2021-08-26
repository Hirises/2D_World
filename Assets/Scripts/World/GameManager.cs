using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static ArrayList generater = new ArrayList();

    private void Awake()
    {
        generateWorld();
    }

    public static void generateWorld()
    {
        foreach (WorldGenerater gen in generater)
        {
            gen.generate();
        }
    }
}
