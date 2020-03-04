using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody rb;

    Vector3 Movement;

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            if(MovingObstacles.speed <= 3000)
            {
                MovingObstacles.speed += 100;
                Debug.Log(MovingObstacles.speed);
                PCG.delayReset = 0.75f;

            }
            
        }

        else if (Input.GetKey(KeyCode.S))
        {
            if(MovingObstacles.speed > 1000)
            {
                MovingObstacles.speed -= 10;
                Debug.Log(MovingObstacles.speed);
            }
            
            
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
    }
}
