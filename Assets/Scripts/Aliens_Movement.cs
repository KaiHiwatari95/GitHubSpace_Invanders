using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens_Movement : MonoBehaviour
{

    public float hp = 1f;

    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidbody2D;

    public float movementSpeed;
    bool moveRight = true;
    bool isShooting = false;



    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 0);
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        if (transform.position.x >= 14)
        {

            transform.position = new Vector2(transform.position.x - 1, transform.position.y - 1);
            movementSpeed = -movementSpeed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 0);

        }
        else if (transform.position.x <= -14)
        {

            transform.position = new Vector2(transform.position.x + 1, transform.position.y - 1);
            movementSpeed = -movementSpeed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, 0);

        }



    }
}
