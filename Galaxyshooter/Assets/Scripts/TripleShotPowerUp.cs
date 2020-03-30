using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShotPowerUp : MonoBehaviour
{
    //public GameObject tripleShotPowerUpPreFab;
    public float tripleMoveSpeed = 1f;
    public Vector3 tripleDir = Vector3.down; 
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(tripleShotPowerUpPreFab, new Vector3(.42f, 6.85f, 0), Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(tripleMoveSpeed * tripleDir * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.GetComponent<Player>().TripleShotActive();
           
            Destroy(gameObject);

        }
    }
}
