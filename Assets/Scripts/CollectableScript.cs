﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour

{
    public Transform myPrefab;
    private int prefabNumber;

    void Start()
    {
        prefabNumber = Random.Range(10, 20);
       // for (int i = 0; i < prefabNumber; i++)
       // {
       //     Instantiate(myPrefab, new Vector3(Random.Range(-4, 4), 0.3f, Random.Range(-4, 4)), Quaternion.identity);
       // }
    }

    // Update is called once per frame
    void Update()
    {

    }

}