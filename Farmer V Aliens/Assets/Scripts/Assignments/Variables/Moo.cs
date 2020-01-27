using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moo : MonoBehaviour
    
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float moveSpeed;
    void Update()
    {
        moveSpeed = .09f;

        transform.Translate(moveSpeed*Input.GetAxis("Horizontal"), 0f, moveSpeed*Input.GetAxis("Vertical"));
      
        
    }

    
    //Detect collision with another object
    private void OnCollisionEnter(Collision other)
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
