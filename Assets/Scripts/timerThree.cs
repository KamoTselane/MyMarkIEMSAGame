using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerThree : MonoBehaviour
{
    public float gametimer = 3;

    void Update()
    {

        gametimer -= Time.deltaTime;
        print(gametimer);


        if (gametimer <= 0)

        {


            SceneManager.LoadScene("8 - Three");
        }
    }
}
