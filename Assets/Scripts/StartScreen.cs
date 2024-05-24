using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("ViewRoom_Scene1");      
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void LoadStartscreen()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void SceneChange()
{
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
    public void SceneChangeBack()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
}
}


