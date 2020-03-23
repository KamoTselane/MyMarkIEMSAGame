using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer : MonoBehaviour
{

    public Text nextText;
    public static string textstring;

    // Start is called before the first frame update
    void Start()
    {
        nextText.text = textstring;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
