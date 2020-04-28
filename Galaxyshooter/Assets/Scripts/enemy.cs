using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 4;
    public GameObject enemyPreFab;
    private Player _player;
  

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

        //move enemy down at 4mps
        //spawn at top if bottom of screen
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -4f)
            transform.position = new Vector3(Random.Range(-7f, 8f), 8, .32f); 

        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.GetComponent<Player>().Damage();
            other.transform.GetComponent<Player>().UpdateDamage();
            Destroy(this.gameObject);
            

        }

        else if (other.gameObject.CompareTag("Laser"))
        {

            //Instantiate(enemyPreFab, new Vector3(Random.Range(-7f, 8f), 8, .32f), Quaternion.identity);
            
            if(_player != null)
            {
                _player.AddScore();
            }
            
            Destroy(gameObject);
        }
    }
}
