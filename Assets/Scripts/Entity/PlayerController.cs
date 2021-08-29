using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float SQRPO = 1 / Mathf.Sqrt(2);

    public Player player;
    private int moveFlag = 0;
    private Settings settings = GameManager.GetSettings();

    private void Update()
    {
        GetMoveInput();
        Move();
    }

    private void GetMoveInput()
    {
        if (Input.GetKeyDown(settings.Player_Move_Forward_Key))
        {
            moveFlag += 1;
        }
        if (Input.GetKeyDown(settings.Player_Move_Backward_Key))
        {
            moveFlag += 2;
        }
        if (Input.GetKeyDown(settings.Player_Move_Left_Key))
        {
            moveFlag += 4;
        }
        if (Input.GetKeyDown(settings.Player_Move_Right_Key))
        {
            moveFlag += 8;
        }

        if (Input.GetKeyUp(settings.Player_Move_Forward_Key))
        {
            moveFlag -= 1;
        }
        if (Input.GetKeyUp(settings.Player_Move_Backward_Key))
        {
            moveFlag -= 2;
        }
        if (Input.GetKeyUp(settings.Player_Move_Left_Key))
        {
            moveFlag -= 4;
        }
        if (Input.GetKeyUp(settings.Player_Move_Right_Key))
        {
            moveFlag -= 8;
        }
    }

    private void Move()
    {
        switch (moveFlag)
        {
            case 1:
            case 13:
                transform.Translate(Vector3.up * settings.Player_Work_Speed * Time.deltaTime);
                break;
            case 2:
            case 14:
                transform.Translate(Vector3.down * settings.Player_Work_Speed * Time.deltaTime);
                break;
            case 4:
            case 7:
                transform.Translate(Vector3.left * settings.Player_Work_Speed * Time.deltaTime);
                break;
            case 8:
            case 11:
                transform.Translate(Vector3.right * settings.Player_Work_Speed * Time.deltaTime);
                break;
            case 9:
                transform.Translate(new Vector3(1, 1, 0) * settings.Player_Work_Speed * Time.deltaTime * SQRPO);
                break;
            case 10:
                transform.Translate(new Vector3(1, -1, 0) * settings.Player_Work_Speed * Time.deltaTime * SQRPO);
                break;
            case 5:
                transform.Translate(new Vector3(-1, 1, 0) * settings.Player_Work_Speed * Time.deltaTime * SQRPO);
                break;
            case 6:
                transform.Translate(new Vector3(-1, -1, 0) * settings.Player_Work_Speed * Time.deltaTime * SQRPO);
                break;
            case 3:
            case 12:
            case 15:
                break;
        }
    }
}
