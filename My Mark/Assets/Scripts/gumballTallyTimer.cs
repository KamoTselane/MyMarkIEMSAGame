using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gumballTallyTimer : MonoBehaviour
{
    public float gametimer = 26;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gametimer -= Time.deltaTime;



        if (gametimer <= 0)

        {
            SceneManager.LoadScene("GarnetWinner");
        }
    }
}
