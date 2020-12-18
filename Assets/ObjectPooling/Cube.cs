using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IPooledObject
{
    public static float speed = 500f;
    public Rigidbody rb;
    public GameObject objectPooler;

    // Start is called before the first frame update
    public void OnObjectSpawn (){
        
    }

    // Update is called once per frame
    void Update()
    {
        //Prints out the obstacles current speed
        Debug.Log("Obstacle Speed: " + speed);

        //Moves rigidbody progressively negative on the z axis
        rb.velocity = new Vector3(0, 0, -speed * Time.deltaTime);

        //Destroys the obstacle once it passes -5 on the z axis
        if (transform.position.z < -5)
        {
            gameObject.SetActive(false);
        }
    }
}
