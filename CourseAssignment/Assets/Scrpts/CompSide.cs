using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompSide : MonoBehaviour
{
public GameManager gameManager;
public BallScript ball;

void OnCollisionEnter(Collision col)
{
    if (ball != null)
    {
        ball.transform.position = new Vector3(0f, 0.20719f, 0f);
        gameManager.PScoreIncrease();
    }
}}