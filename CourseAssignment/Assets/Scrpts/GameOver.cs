using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public Text gameOver;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.pscore == 5)
        {
            gameOver.enabled = true;
            gameOver.text = "You Won";
        }
        if(gameManager.cscore ==5)
        {
            gameOver.enabled = true;
            gameOver.text = "Computer Won";
        }
    }
}