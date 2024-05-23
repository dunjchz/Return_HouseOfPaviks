using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorDialogueActive : MonoBehaviour
{

   public GameObject MonitorDialoguePanel2;

   void Start()
   {
       //Debug.Log("Button1");
       MonitorDialoguePanel2.SetActive(false);
   }

   public void OpenPanel()
   {
       //Debug.Log("Button2");
       MonitorDialoguePanel2.SetActive(true);

   }

   public void ClosePanel()
   {
       //Debug.Log("Button3");
       MonitorDialoguePanel2.SetActive(false);
   }

}
