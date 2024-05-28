using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour

{
    public void OnMouseDown()
    {
        if (GameManager.Instance.AreAllLocksSolved())
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
        Application.Quit(); 
    }
}