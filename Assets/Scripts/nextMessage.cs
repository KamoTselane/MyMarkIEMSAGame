using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextMessage : MonoBehaviour
{
    private bool isClicked = false;
    public InputField nextText;

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
            answer.textstring = nextText.text;
            SceneManager.LoadScene("Answers");
        }
    }

}
