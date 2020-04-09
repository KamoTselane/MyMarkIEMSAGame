using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpongebobTally : MonoBehaviour
{
    public KeyCode space;
    public float speed=4;
    public Rigidbody2D barrigid;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(space))

        {
            barrigid.velocity = new Vector2(0, speed);
        }

        else barrigid.velocity = new Vector2(0, 0);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "barrier1")
        {
            SceneManager.LoadScene("10 - SpongebobWinner");

        }

    }
}
