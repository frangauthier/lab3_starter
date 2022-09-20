using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5f;
    [SerializeField] float jumpForce = 7f;
    Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float moveFactor = Input.GetAxis("Horizontal");

        if (Input.GetAxis("Horizontal") != 0)
        {
            // Velocity -- good movement, stops on release
            playerRB.velocity = new Vector2(moveFactor * maxSpeed, playerRB.velocity.y);

        }
    }

    void Jump()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
        }
    }
}
