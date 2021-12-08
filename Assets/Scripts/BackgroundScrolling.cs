using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{

    public float SpeedScrolling;
    public float Width;

    public BoxCollider2D bc;
    public Rigidbody2D rb;





    void Start()
    {

        Width = bc.size.y;
        bc.enabled = false;

        rb.velocity = new Vector2(0, SpeedScrolling);

    }





    void Update()
    {

        if (transform.position.y < -Width)
        {

            Vector2 ResetPosition = new Vector2(0, Width);
            transform.position = ResetPosition;

        }

    }


}
