using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mazeScript : MonoBehaviour
{
    public KeyCode left, right, up, down;
    public float speed;
    public Rigidbody2D flagrigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(left))
        {
            flagrigid.velocity = new Vector2(-speed, 0);
        }

        if (Input.GetKeyDown(right))
        {
            flagrigid.velocity = new Vector2(speed, 0);
        }

        if (Input.GetKeyDown(up))
        {
            flagrigid.velocity = new Vector2(0, speed);
        }

        if (Input.GetKeyDown(down))
        {
            flagrigid.velocity = new Vector2(0, -speed);
        }



    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Finish")
        {
            SceneManager.LoadScene("7 - Vote");

        }

    }
}
