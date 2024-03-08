using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Game");      
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
