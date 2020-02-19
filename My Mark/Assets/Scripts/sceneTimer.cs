using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneTimer : MonoBehaviour
{
    public GameObject logo, menu;
    public float gametimer = 3;

    // Start is called before the first frame update
    void Start()
    {
        logo.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gametimer -= Time.deltaTime;

        if (gametimer <= 0)

        {
            logo.gameObject.SetActive(false);
            menu.gameObject.SetActive(true);
        }
    }
}
