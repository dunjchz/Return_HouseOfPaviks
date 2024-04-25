using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPanelSetActive : MonoBehaviour
{

    public GameObject lockPanel;

   void Start()
    {
        lockPanel.SetActive(false);
    }

    public void ActivatePanel()
    {
        //Debug.Log("Panel Activated!");
        lockPanel.SetActive(true);
      
    }

    public void DeactivatePanel()
{
    //Debug.Log ("Panel Closed!");
    lockPanel.SetActive(false);
}

}
