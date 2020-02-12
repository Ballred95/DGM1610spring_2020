using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float speed;
    public float verticalInput;
    public float horizontalInput;
    [SerializeField]
    private GameObject laserPreFab;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public float moveSpeed;
    public float turnSpeed;
    
    void Update()
    {
        moveSpeed = 10f;
        turnSpeed = 150f;


        /*transform.Translate(moveSpeed * Input.GetAxis("Horizontal"), 0f, moveSpeed * Input.GetAxis("Vertical")); */

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPreFab, transform.position + (Vector3.forward * 2), laserPreFab.transform.rotation);
            Debug.Log("Hit space key");
        }


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

        else if (other.gameObject.CompareTag("Button"))
        {

            Debug.Log("hit button");
        }
                

                
                
                
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You have entered the trigger zone");
        if(other.gameObject.CompareTag("ButtonTrigger"))
        {
            Debug.Log("Entered button trigger area");
        }
       
        else if (other.gameObject.CompareTag("Outside"))
        {
            Debug.Log("Fell off");

        }
    }

  
}


