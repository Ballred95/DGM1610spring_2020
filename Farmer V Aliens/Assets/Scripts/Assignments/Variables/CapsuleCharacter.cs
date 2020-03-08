using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCharacter : MonoBehaviour
{
    private CharacterController _controller;
    private float _speed = 20;
    private float _graivty = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // get horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // define direction based on input 
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        //move based on that direction
        Vector3 velocity = direction * _speed;


        _controller.Move(velocity * Time.deltaTime);

        if (_controller.isGrounded == true)
        {


        }

        else
        {
            velocity.y -= 
            
        }

        
    }
}
