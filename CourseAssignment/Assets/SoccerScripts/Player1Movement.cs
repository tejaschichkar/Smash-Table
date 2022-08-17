using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 5;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        if(!gameManager.win && !gameManager.loose)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (-1f, 0, 0)*0;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0, 0)*0;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, -1f)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, -1f)*0;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 1f)*speed;
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 1f)*0;
            }
        }
    }
}
