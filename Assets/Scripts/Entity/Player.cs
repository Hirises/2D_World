using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Location location;
    private bool isremote;
    [SerializeField]
    private PlayerController controller;

    public Player(Location location, bool isremote)
    {
        this.location = location;
        this.isremote = isremote;
        if (isremote)
        {
            controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
            controller.player = this;
        }
    }

    public bool IsRemote()
    {
        return isremote;
    }

    public Location GetLocation()
    {
        return location;
    }

    public void UpdateLocation()
    {
        location = new Location(location.world, controller.transform.position);
    }

    public PlayerController GetController()
    {
        return controller;
    }
}
