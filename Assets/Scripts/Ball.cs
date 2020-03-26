using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    int speed = 20;
    float bx;
    float by;
    float bz;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        /*
                bx = Input.acceleration.x;
                by = Input.acceleration.y;
        */
        bx = 0;
        by = 0;
        bz = 0;
        movement = new Vector3(bx, 0.0f, by);

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        bx = Input.acceleration.x;

        by = by + 0.005f;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
        }

        movement = new Vector3(bx * speed, 0.0f, by);
        rb.AddForce(movement);

    }

    void FixedUpdate()
    {
        movement = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);
        if (Input.GetMouseButtonDown(0))
        {
            //jump here
            rb.velocity = new Vector3(rb.velocity.x, 5, rb.velocity.z);
        }

    }

    public void Jump()
    {
        bz = bz + 0.5f;
    }
}


    
