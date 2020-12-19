using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    [SerializeField]
    private GameObject coinPrefab;
    [SerializeField]
    private Queue<GameObject> coinPool = new Queue<GameObject>();
    [SerializeField]
    private int poolStartSize = 5;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject coin = Instantiate(coinPrefab);
            coinPool.Enqueue(coin);
            coin.SetActive(false);
        }
    }

    public GameObject GetCoin()
    {
        if (coinPool.Count > 0)
        {
            GameObject coin = coinPool.Dequeue();
            coin.SetActive(true);
            return coin;
        }
        else
        {
            GameObject coin = Instantiate(coinPrefab);
            return coin;
        }
    }

    public void ReturnCoin(GameObject coin)
    {
        coinPool.Enqueue(coin);
        coin.SetActive(false);
    }
}
