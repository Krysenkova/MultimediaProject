﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public Transform player;
    private Vector2 movement;
    public float moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(player);

        transform.position += transform.forward * moveSpeed * Time.deltaTime;

    }

}
