using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody player;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        player.velocity = new Vector3(horizontalInput*movementSpeed, player.velocity.y, verticalInput*movementSpeed);

        if (Input.GetButtonDown("Jump") && isGround())
        {
            player.velocity = new Vector3(player.velocity.x,jumpForce,player.velocity.z);
        }

    }
    bool isGround()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}
