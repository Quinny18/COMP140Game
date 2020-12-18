using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float timeToSpawn = 5f;
    private float timeSinceSpawn;
    public ObjectPooling objectPool;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn >= timeToSpawn)
        {
            GameObject newCoin = objectPool.GetCoin();
            newCoin.transform.position = new Vector3(transform.position.x + Random.Range(-6.5f, 6.5f), transform.position.y, transform.position.z);
            timeSinceSpawn = 0f;
        }
    }
}
