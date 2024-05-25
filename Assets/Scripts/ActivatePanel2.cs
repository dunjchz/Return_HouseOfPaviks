using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanel2 : MonoBehaviour
{
    public GameObject RedPanel;

    void Start()
    {
        RedPanel.SetActive(false);
    }

    public void OpenPanel()
    {
        RedPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        RedPanel.SetActive(false);
    }
}
