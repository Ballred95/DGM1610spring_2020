﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //move enemy down at 4mps
        //spawn at top if bottom of screen
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -4f)
            transform.position = new Vector3(Random.Range(-7f, 8f), 8, .32f); 

    }
}
