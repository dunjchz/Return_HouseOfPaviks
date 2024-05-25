using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanel : MonoBehaviour
{ 
    public GameObject GreenPanel;

    void Start()
    {
    GreenPanel.SetActive(false);
      }

    public void OpenPanel()
    {
    GreenPanel.SetActive(true);
    }

    public void ClosePanel()
    {
    GreenPanel.SetActive(false);
       }
}
