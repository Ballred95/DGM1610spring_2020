using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject laserPreFab;
    [SerializeField]
    public float speed = 5.3f;
    [SerializeField]
    private float fireRate = 0.5f;
    private float canFire = -1f;
    public int lives = 3;
    private SpawnManager spawnManager;
    public GameObject tripleShot;
    public bool tripleShotActive = false;
    [SerializeField]
    private int score;
    private UIManager _uiManager;


    // Start is called before the first frame update
    void Start()
    {
        //Take current position and assign as start position. 
        transform.position = new Vector3(0, -3.38f, 0);
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        if(_uiManager == null)
        {

        }

        if (spawnManager == null)

        {

            Debug.LogError("Spawn manager is null, error");
        }




    }

    // Update is called once per frame
    void Update()
    {

        calcMove();
        FireLaser();
        Death();
        TripleShot();


    }

    void calcMove()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalMouse = Input.GetAxis("Mouse X");
        float verticalMouse = Input.GetAxis("Mouse Y");


        //transform.Translate(Vector3.right * speed * horizontalMouse * Time.deltaTime);
        //transform.Translate(Vector3.up * speed * verticalMouse * Time.deltaTime);
        //transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        //tansform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);
        //tansform.Rotate(Vector3.up * 150 * verticalMouse * Time.deltaTime);
        //transform.Rotate(Vector3.right * 150 * horizontalMouse * Time.deltaTime);

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * speed * Time.deltaTime);
        // if player position is greater than 5 on y position
        //set y = 5
        //else if player position is greater than 4
        // y=4


        if (transform.position.y >= 5)

        {
            transform.position = new Vector3(transform.position.x, 5, 0);

        }
        else if (transform.position.y <= -4)

        {
            transform.position = new Vector3(transform.position.x, -4, 0);

        }

        //if player on x is greater than -- 
        // x pos = - --
        // else if player on x is less than -- 
        //x pos = +--

        else if (transform.position.x >= 9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }

        else if (transform.position.x <= -9)

        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
    }

    void FireLaser()
    {
        //if i hit space key, 
        //spawn gameObject
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canFire)
        {
            canFire = Time.time + fireRate;
            if (tripleShotActive == true)

            {
                Instantiate(tripleShot, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity);


            }



            else

                Instantiate(laserPreFab, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity);
            Debug.Log("Hit space key");
        }

    }

    void TripleShot()

    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(tripleShot, transform.position + new Vector3(0, 0.8f, 0), Quaternion.identity);

        }

    }


    public void Damage()

    {

        lives--;
        _uiManager.UpdateDamage(lives);

    }

    public void AddScore()
    {
        score += 10;
        _uiManager.UpdateScore(score);
    }


    public void TripleShotActive()
    {
        tripleShotActive = true;
        StartCoroutine(TripleShotPowerDownRoutine());

    }

    void Death()
    {
        if (lives <= 0)
        {

            Destroy(this.gameObject);
            spawnManager.onPlayerDeath();


        }

    }

    IEnumerator TripleShotPowerDownRoutine()
    {

        yield return new WaitForSeconds(2.0f);
        tripleShotActive = false;

    }
}
