using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    public GameObject piece;

    public GameConfiguration gameConfiguration;
    public GridSettings gridSettings;

    float timer;

    bool isMovable = true;

    void Start()
    {
        
    }


    void Update()
    {
        if (isMovable)
        {
            timer += 1 * Time.deltaTime;

            if (Input.GetKey(KeyCode.DownArrow) && timer >= gameConfiguration.HighDropFrequency.Value)
            {
                GoDown();
            }
            else if (timer >= gameConfiguration.RegularDropFrequency.Value)
            {
                GoDown();
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Movement(KeyCode.LeftArrow);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Movement(KeyCode.RightArrow);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Movement(KeyCode.UpArrow);
            }
        }
    }
    void Movement(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.LeftArrow:
                piece.transform.position -= Vector3.right;
                if (!CheckPositionValidation())
                {
                    piece.transform.position += Vector3.right;
                    break;
                }
                break;
            case KeyCode.RightArrow:
                piece.transform.position += Vector3.right;
                if (!CheckPositionValidation())
                {
                    piece.transform.position -= Vector3.right;
                    break;
                }
                break;
            case KeyCode.UpArrow:
                piece.transform.eulerAngles += Vector3.forward * 90f;
                if (!CheckPositionValidation())
                {
                    piece.transform.eulerAngles -= Vector3.forward * 90f;
                    break;
                }
                break;

        }    
    }
    void GoDown()
    {
        piece.transform.position -= Vector3.up;
        timer = 0f;
        if (!CheckPositionValidation())
        {
            piece.transform.position += Vector3.up;
            isMovable = false;
        }
    }

    bool CheckPositionValidation()
    {
        foreach (Transform block in piece.transform)
        {
            if(block.transform.position.x >= gridSettings.Width.Value || block.transform.position.x < 0 || block.transform.position.y < 0)
            {
                Debug.LogError(block.transform.position.x);
                return false;
            }
        }
        return true;
    }
}
