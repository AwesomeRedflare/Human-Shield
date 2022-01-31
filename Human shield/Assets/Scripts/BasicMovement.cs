using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private int score = 0;

    Vector3 movement;
    public float speed = 5f;
    public Rigidbody2D rb;

    void Update()
    {
        Move();

        
    }

    private void Move()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
    

        // transform.position = transform.position + movement * speed * Time.deltaTime;

        rb.velocity = new Vector2(movement.x, movement.y) * speed;
    }

    private void OnTriggerEnter2D(Collider2D block)
    {
        Score.scoreAmount++;
    }
}
