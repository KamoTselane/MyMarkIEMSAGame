using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouthTime : MonoBehaviour
{
    public GameObject talk, silent, next;  
    public float gametimer = 13;

    // Start is called before the first frame update
    void Start()
    {
        talk.gameObject.SetActive(true);
        silent.gameObject.SetActive(false);
        next.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gametimer -= Time.deltaTime;

        if (gametimer <= 0)

        {
            talk.gameObject.SetActive(false);
            silent.gameObject.SetActive(true);
            next.gameObject.SetActive(true);
        }
    }
}
