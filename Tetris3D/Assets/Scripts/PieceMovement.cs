using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{
    public GameObject piece;

    public GameConfiguration gameConfiguration;

    float timer;

    void Start()
    {
        
    }


    void Update()
    {
        timer += 1 * Time.deltaTime;

        if(Input.GetKey(KeyCode.DownArrow) && timer >= gameConfiguration.HighDropFrequency.Value)
        {
            GoDown();
        }
        else if (timer >= gameConfiguration.RegularDropFrequency.Value)
        {
            GoDown();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            piece.transform.position -= Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            piece.transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            piece.transform.eulerAngles += Vector3.forward * 90f;
        }
    }

    void GoDown()
    {
        piece.transform.position -= Vector3.up;
        timer = 0f;
    }
}
