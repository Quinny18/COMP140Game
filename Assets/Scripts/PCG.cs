using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCG : MonoBehaviour
{
    //This list stores all of the prefabs that we are spawning
    public GameObject[] prefabs;
    private float delay;
    [SerializeField]
    public static float delayReset;
    public Vector3 spawnPos;
    [SerializeField]
    private float radius;

    // Start is called before the first frame update
    void Start()
    {
        delayReset = 2f;
        radius = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //Spawning in the prefabs on a delay
        if (delay <= 0)
        {
            int random = Random.Range(1, 5);
            while (random > 0)
            {
                //This makes sure more coins are spawned than obstacles
                int moreCoins = Random.Range(0, 10);
                GameObject prefabToUse = prefabs[0];
                if (moreCoins < 6)
                {
                    //This iterates through prefabs and checks if the current element is a coin or not
                    foreach (GameObject p in prefabs)
                    {
                        if (p.name == "Coins")
                        {
                            prefabToUse = p;
                        }
                    }
                }
                else
                {
                    foreach (GameObject p in prefabs)
                    {
                        if (p.name == "Obstacles")
                        {
                            prefabToUse = p;
                        }

                    }
                }

                spawnPos = new Vector3(transform.position.x + Random.Range(-6.5f, 6.5f), transform.position.y, transform.position.z);

                //Intended to stop objects from spawning within each other
                if (Physics.CheckSphere(spawnPos, radius))
                {
                    Debug.Log("Found Something");
                }
                Instantiate(prefabToUse, spawnPos, Quaternion.identity);
                random--;
            }
            delay = delayReset;
        }
        else
        {
            delay -= Time.deltaTime;
        }
    }
}
