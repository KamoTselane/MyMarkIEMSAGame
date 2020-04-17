using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourButtonScript : MonoBehaviour
{
    public GameObject one, two, three, four, five;


    // Start is called before the first frame update
    void Start()
    {
        one.gameObject.SetActive(false);
        two.gameObject.SetActive(false);
        three.gameObject.SetActive(false);
        four.gameObject.SetActive(false);
        five.gameObject.SetActive(false);

    }
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

            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(true);
            five.gameObject.SetActive(false);
        }
    }
}

