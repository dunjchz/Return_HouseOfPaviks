using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour

{
    private void OnMouseDown()
    {
        
        Debug.Log("Object Clicked: " + gameObject.name);
        
       
    }
}



