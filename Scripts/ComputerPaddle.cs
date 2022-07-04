using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D ball;
    private Rigidbody2D rb;
    private Vector2 move;
    public Ball ballScript;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (ballScript.bounceLocation.x <= 13.0f)
        {

            if (ball.position.y > transform.position.y)
                move = Vector2.up * speed;
            else if (ball.position.y < transform.position.y)
                move = Vector2.down * speed;
        }
        else
        {
            if (ball.position.y > transform.position.y)
                move = Vector2.up * speed;
            else if (ball.position.y < transform.position.y)
                move = Vector2.down * speed;
        }

        if (Mathf.Abs(rb.velocity.y - move.y) > 1.75f || ball.position.x > 13)
        {
            rb.velocity = move;
        }
    }
}
