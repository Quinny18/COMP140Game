using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoinPickUp : MonoBehaviour
{
    //This checks if the player has collided with the coins or an obstacle.
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Coins"))
        {
            //Adds one to score and destroys the coin you collided with
            ScoreCounter.scoreValue += 1;
            collider.gameObject.SetActive(false);

        }
        else if (collider.gameObject.CompareTag("Obstacles"))
        {
            //Destroys the player is you collide with a wall
            gameObject.SetActive(false);
        }
    }

}
