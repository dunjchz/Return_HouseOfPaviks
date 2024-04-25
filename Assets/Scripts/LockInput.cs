using UnityEngine;
using TMPro;

public class LockInput : MonoBehaviour
{
    
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;

    public TextMeshProUGUI errorMessage;
    public GameObject lockPanel;
    
    

    public void OnSubmitButtonPressed()
    {
        
        if (inputField1.text == "4" && inputField2.text == "7" && inputField3.text == "7")
        {

            //Debug.Log("Code is correct, u have fuel now");
            errorMessage.text = "Code correct! You have a fuel now.";
            lockPanel.SetActive(false);
            PlayerPrefs.SetInt("LockSolved", 1); 
            
        }
        else
        {
            //Debug.Log("Code is incorrect!");
            errorMessage.text = "Code incorrect! Try again.";
        }
    }

}
