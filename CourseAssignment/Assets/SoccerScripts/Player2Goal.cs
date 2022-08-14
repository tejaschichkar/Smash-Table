using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Goal : MonoBehaviour
{
    public GameObject ball;
    public GameManager gameManager;

    void OnCollisionEnter(Collision col)
    {
        if (ball != null)
        {
            ball.transform.position = new Vector3(-0.3f, 1.15f, 0f);
            ball.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
            gameManager.CScoreIncrease();
        }
    }
}
