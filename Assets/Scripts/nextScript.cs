using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScript : MonoBehaviour
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
            SceneManager.LoadScene("End");
        }
    }
}
