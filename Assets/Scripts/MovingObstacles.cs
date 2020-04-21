using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    [SerializeField]
    public static float speed = 100f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Obstacle Speed: " + speed);
        rb.velocity = new Vector3(0, 0, -speed * Time.deltaTime);

        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }

    }


}
