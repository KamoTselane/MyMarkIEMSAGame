using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exitGame : MonoBehaviour
{
    private bool isClicked = false;

    private void OnMouseDown()
    {
        isClicked = true;
    }

    private void OnMouseUp()
    {
        isClicked = false;
    }
    void Update()
    {
        if (isClicked)

        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }
}
