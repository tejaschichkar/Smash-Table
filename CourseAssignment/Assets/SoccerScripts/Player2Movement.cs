using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private float speed = 5;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        if(!gameManager.win && !gameManager.loose)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.L))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*0;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.J))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*0;
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, -1f)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.I))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, -1f)*0;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 1f)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.K))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 1f)*0;
            }
        }
    }
}
