﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneyMove : MonoBehaviour
{

    public Transform target;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(target.position);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


    }
}
