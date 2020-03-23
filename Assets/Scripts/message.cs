using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class message : MonoBehaviour
{
    public string theMessage;
    public GameObject inputField;
    public GameObject messageDisplay;


    public void StoreMessage()
    {
        theMessage = inputField.GetComponent<Text>().text;
        messageDisplay.GetComponent<Text>().text = "Submitted! Thank you.";
    }

}
