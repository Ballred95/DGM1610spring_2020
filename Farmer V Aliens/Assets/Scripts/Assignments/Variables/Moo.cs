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
    
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
       // print(Input.GetAxis("Horizontal"));
        
    }

    
    //Detect collision with another object
    private void OnCollisionEnter(Collision other)
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
