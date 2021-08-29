using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    private Player player;
    private Settings settings = GameManager.GetSettings();

    private void LateUpdate()
    {
        Vector3 postion = player.GetController().transform.position;
        postion.z = settings.Camera_Z_Postion;
        transform.position = postion;
    }

    public Player GetTargetPlayer()
    {
        return player;
    }

    public void SetTargetPlayer(Player target)
    {
        player = target;
    }
}
