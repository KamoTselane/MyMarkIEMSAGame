using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerOne : MonoBehaviour
{
    public float gametimer = 5;

    void Update()
    {

        gametimer -= Time.deltaTime;
        print(gametimer);


        if (gametimer <= 0)

        {


            SceneManager.LoadScene("One");
        }
    }
}
