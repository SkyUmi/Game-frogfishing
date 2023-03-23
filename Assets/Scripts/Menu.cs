using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int _score;
    public void NewGame()
    {
       
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }
    public void GoToMenu()
    {

        ScoreHandleController.instance.score = 0;
        SceneManager.LoadScene(0);
       
    }
    public  void OutGame()
    {
        Application.Quit();
    }
    public void lv_Hard()
    {
       
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(6);
    }
}
