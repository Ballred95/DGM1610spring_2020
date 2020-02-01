using System.Collections;
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
        float horizontalInput = Input.GetAxis("Horizontal");
        float horizontalMouse = Input.GetAxis("Mouse X");
        float verticalMouse = Input.GetAxis("Mouse Y");

        transform.Translate(Vector3.right * speed * horizontalMouse * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalMouse * Time.deltaTime);

    }
}
