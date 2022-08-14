using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalText : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public Text goalText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.pscore == 5)
        {
            goalText.enabled = true;
            goalText.text = "Player1 Won";
        }
        if(gameManager.cscore ==5)
        {
            goalText.enabled = true;
            goalText.text = "player2 Won";
        }
    }
}
