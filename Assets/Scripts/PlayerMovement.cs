using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float speedInput;
    public Rigidbody rb;

    Vector3 Movement;

    // Update is called once per frame
    void Update()
    {
       
        Movement.x = Input.GetAxisRaw("Horizontal");
        if (speedInput < 50f)
        {
            MovingObstacles.speed = 900f;

        }
        else if (speedInput > 50f && speedInput < 350f)
        {
            MovingObstacles.speed = 1850f;
        }
        else if (speedInput >= 350f)
        {
            MovingObstacles.speed = 2550f;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
    }

    void Gear1()
    {
        
    }

    void Gear2()
    {
        
    }
    void Gear3()
    {
        
    }
    void Gear4()
    {
        
    }
    void Gear5()
    {
        
    }
}
