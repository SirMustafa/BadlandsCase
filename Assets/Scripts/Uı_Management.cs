using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uı_Management : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject mainCanvas;
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void reStartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale= 1.0f;
    }
    public void resumGame()
    {
        Time.timeScale = 1.0f;
        Canvas.SetActive(false);
    }
    public void quitGame() 
    {
        SceneManager.LoadScene("Uı");
    }
    public void pauseGame()
    {
        Time.timeScale = 0f;
        Canvas.SetActive(true);
    }
    private void FixedUpdate()
    {
        if (mainCanvas.activeSelf)
        {
            if (Input.GetKeyUp(KeyCode.Q))
            {
                Application.Quit();
            }
        }  
        
    }
}
