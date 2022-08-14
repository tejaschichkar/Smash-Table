using UnityEngine;
using UnityEngine.UI;

public class Cscore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public Text score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Computer : " + gameManager.cscore;
    }
}
