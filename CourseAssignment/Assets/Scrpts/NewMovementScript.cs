using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementScript : MonoBehaviour
{
    private float speed = 5;
    public GameManager gameManager;

    void Update()
    {
        void MoveRight()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*0;
            }
        }
        void MoveLeft()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*0;
            }
        }
        if(!gameManager.win && !gameManager.loose)
        {
            MoveRight();
            MoveLeft();
        }
    }
}
