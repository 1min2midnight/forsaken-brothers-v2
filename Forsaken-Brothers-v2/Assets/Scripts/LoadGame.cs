using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    private int sceneToContinue;

    public void LoadTheSavedScene()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue != 0)
           SceneManager.LoadScene(sceneToContinue);
        else
           return;   
        
    }
}
