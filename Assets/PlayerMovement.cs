using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            player.velocity = new Vector3(0,5,0);
        }
        if (Input.GetKey("up"))
        {
            player.velocity = new Vector3(0, 0, 5);
        }
        if (Input.GetKey("right"))
        {
            player.velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            player.velocity = new Vector3(0, 0, -5);
        }
        if (Input.GetKey("left"))
        {
            player.velocity = new Vector3(-5, 0, 0);
        }

    }
}
