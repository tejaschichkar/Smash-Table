using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject Ball;
    public Vector3 initialImpulse;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }
// Update is called once per frame
    void FixedUpdate()
    {
        if(gameManager.win || gameManager.loose)
        {
            Ball = GameObject.Find("Ball");
            //This locks the RigidBody so that it does not move in the Z & X axis.
            Ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
        }
    }
}
