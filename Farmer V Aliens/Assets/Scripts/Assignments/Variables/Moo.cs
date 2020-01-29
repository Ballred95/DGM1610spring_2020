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

        transform.Translate(moveSpeed * Input.GetAxis("Horizontal"), 0f, moveSpeed * Input.GetAxis("Vertical"));


    }

    private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Colliding with floow");
        }

        else if (other.gameObject.CompareTag("Obstacle"))

        {
            Debug.Log("Colliding with Obstacle");

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You have entered the trigger zone");
       
    }

}


