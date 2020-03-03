using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneyMove : MonoBehaviour
{
    public GameObject player;
    public Vector3 target;
    public int moveSpeed;
    public int damage;
    private Rigidbody enemyRB;
    

    // Start is called before the first frame update
    void Start()
    {
       
        
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

       // player = GameObject.Find("Player");
       // target = player.transform.position;
       // transform.LookAt(target);
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        //Add Force
        enemyRB.AddForce((player.transform.position - transform.position).normalized*moveSpeed);
        //Add Velocity
       
    }

}
