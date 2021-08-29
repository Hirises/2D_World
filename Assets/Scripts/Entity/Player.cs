using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private World world;
    [SerializeField]
    private PlayerController controller;

    public Player(World world)
    {
        this.world = world;
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        controller.player = this;
    }

    public PlayerController GetController()
    {
        return controller;
    }
}
