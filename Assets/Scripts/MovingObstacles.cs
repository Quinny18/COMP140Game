using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    [SerializeField]
    public static int speed { get; set; }
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 950;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, -speed * Time.deltaTime);

        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }

    }


}
