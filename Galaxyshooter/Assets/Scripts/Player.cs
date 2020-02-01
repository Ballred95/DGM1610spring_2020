﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5.3f;
    // Start is called before the first frame update
    void Start()
    {
        //Take current position and assign as start position. 
        transform.position = new Vector3(0, -3.38f, 0);




    }

    // Update is called once per frame
    void Update()
    {

        calcMove();
    }

    void calcMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalMouse = Input.GetAxis("Mouse X");
        float verticalMouse = Input.GetAxis("Mouse Y");

        //transform.Translate(Vector3.right * speed * horizontalMouse * Time.deltaTime);
        //transform.Translate(Vector3.up * speed * verticalMouse * Time.deltaTime);
        //ransform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        //ansform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);
        //ansform.Rotate(Vector3.up * 150 * verticalMouse * Time.deltaTime);
        //ransform.Rotate(Vector3.right * 150 * horizontalMouse * Time.deltaTime);

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * speed * Time.deltaTime);
        // if player position is greater than 5 on y position
        //set y = 5
        //else if player position is greater than 4
        // y=4


        if (transform.position.y >= 5)

        {
            transform.position = new Vector3(transform.position.x, 5, 0);

        }
        else if (transform.position.y <= -4)

        {
            transform.position = new Vector3(transform.position.x, -4, 0);

        }

        //if player on x is greater than -- 
        // x pos = - --
        // else if player on x is less than -- 
        //x pos = +--

        else if (transform.position.x >= 9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }

        else if (transform.position.x <= -9)

        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
    }

}
