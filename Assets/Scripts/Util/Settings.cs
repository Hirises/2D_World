using UnityEngine;
using System.Collections;
using NaughtyAttributes;

public class Settings : MonoBehaviour
{
    //월드 세팅
    public static int Block_Per_Chunk = 16;

    public static float Camera_Z_Postion = -30f;

    public static float Player_Work_Speed = 2.5f;


    //플레이어 세팅

    public KeyCode Player_Move_Forward_Key = KeyCode.W;
    public KeyCode Player_Move_Backward_Key = KeyCode.S;
    public KeyCode Player_Move_Left_Key = KeyCode.A;
    public KeyCode Player_Move_Right_Key = KeyCode.D;
}
