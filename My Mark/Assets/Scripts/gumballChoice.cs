using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gumballChoice : MonoBehaviour
{
    public KeyCode enter, back;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(enter))
        {
            SceneManager.LoadScene("GumballTally");
        }

        else if (Input.GetKey(back))

        {
            SceneManager.LoadScene("Vote");
        }
    }
}
