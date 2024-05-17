using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorDialogueActive : MonoBehaviour
{

   public GameObject MonitorDialoguePanel;

   void Start()
   {
       //Debug.Log("Button1");
       MonitorDialoguePanel.SetActive(false);
   }

   public void OpenPanel()
   {
       //Debug.Log("Button2");
       MonitorDialoguePanel.SetActive(true);

   }

   public void ClosePanel()
   {
       //Debug.Log("Button3");
       MonitorDialoguePanel.SetActive(false);
   }

}
