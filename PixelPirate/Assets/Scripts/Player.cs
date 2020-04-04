using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMove();


    }

    void PlayerMove()
    {
        

        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(new Vector2(1, -1) * speed * Time.deltaTime);

        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(new Vector2(-1, 1) * speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(.5f, 0) * speed * Time.deltaTime);

        }

    }
}
