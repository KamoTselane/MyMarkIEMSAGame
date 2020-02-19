using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitScript : MonoBehaviour
{
    public KeyCode esc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(esc))
        {
            Application.Quit();

        }
    }
}
