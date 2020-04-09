using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timeScript : MonoBehaviour
{
    public float gametimer = 32;
    public Text timertext;

    // Start is called before the first frame update
    void Start()
    {
        timertext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        gametimer -= Time.deltaTime;
        timertext.text = gametimer.ToString("f0");
        print(gametimer);


        if (gametimer <= 0)

        {
            SceneManager.LoadScene("6 - Maze");
        }
    }
}
