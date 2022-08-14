using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSide : MonoBehaviour
{
    public GameObject ball;
    public GameObject Player1;
    public GameObject Player2;

    void OnCollisionEnter(Collision col)
    {
        if (ball != null)
        {
            ball.transform.position = new Vector3(-0.3f, 1.15f, 0f);
            ball.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
            Player1.transform.position = new Vector3(-0.3f, 1.15f, 2.25f);
            Player2.transform.position = new Vector3(-0.3f, 1.15f, -2.25f);
        }
    }
}
