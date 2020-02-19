﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goVote : MonoBehaviour
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
            SceneManager.LoadScene("Maze");
        }
    }
}