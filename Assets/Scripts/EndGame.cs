using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour

{
    public void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("LockSolved", 0) == 1)
        {
            EndGameButton();
        }
        else
        {
            Debug.Log("Try something else now."); 
        }
    }

    void EndGameButton()
    {
        Debug.Log("Game ended!"); 
    }
}