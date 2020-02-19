using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characeterVote : MonoBehaviour
{
    public GameObject timer, mark;
   
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
            timer.gameObject.SetActive(true);
            mark.gameObject.SetActive(true);
           
        }


    }
}
