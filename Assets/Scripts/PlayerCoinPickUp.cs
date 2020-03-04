using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoinPickUp : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Coins"))
        {
            //Debug.Log("Collided");
            ScoreCounter.scoreValue += 1;
            Destroy(collider.gameObject);

        }
        else if (collider.gameObject.CompareTag("Obstacles"))
        {
            //Debug.Log("You crashed into the wall!");
            Destroy(gameObject);
            
        }
    }

}
