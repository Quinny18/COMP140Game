﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnCoin : MonoBehaviour
{

    private ObjectPooling objectPool;

    // Start is called before the first frame update
    private void Start()
    {
        objectPool = FindObjectOfType<ObjectPooling>();
    }

    private void OnDisable()
    {
        if(objectPool != null)
        {
            objectPool.ReturnCoin(this.gameObject);
        }
    }
}
