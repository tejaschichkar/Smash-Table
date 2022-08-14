using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1Score : MonoBehaviour
{
    public GameManager gameManager;
    public Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Player1 : " + gameManager.pscore;
    }
}
