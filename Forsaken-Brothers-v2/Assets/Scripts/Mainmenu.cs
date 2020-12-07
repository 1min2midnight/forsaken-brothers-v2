using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    private int sceneToContinue;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoToInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void GoToMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
    public void LoadTheSavedScene()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue != 0)
           SceneManager.LoadScene(sceneToContinue);
        else
           return;   
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
