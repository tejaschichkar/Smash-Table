using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ReloadPongScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ReloadSoccerScene()
    {
        SceneManager.LoadScene(2);
    }
    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }
    public void PongScene()
    {
        SceneManager.LoadScene(1);
    }
    public void SoccerScene()
    {
        SceneManager.LoadScene(2);
    }
}
