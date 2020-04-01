using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPreFab;
    [SerializeField]
    private GameObject enemyContainer;
    private bool stopSpawning = false;
    public GameObject killAll;
    public GameObject tripleShotPowerUpPreFab;
    public GameObject speedPowerUpPreFab;
    void Start()
    {
       // Instantiate(tripleShotPowerUpPreFab, new Vector2(.42f, 6.85f), Quaternion.identity); 
        StartCoroutine(SpawnRoutine());
        StartCoroutine(SpawnPowerRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
        if(killAll == null)
        {
            Destroy(enemyContainer);

        }

       

    }

    IEnumerator SpawnRoutine()
    {
        //while loop
        while(stopSpawning == false)
        {
           GameObject newEnemy = Instantiate(enemyPreFab, new Vector3(0, 7.15f, 0), Quaternion.identity);
            newEnemy.transform.parent = enemyContainer.transform;
            yield return new WaitForSeconds(1);
        }
        
        //infinite loop
        //instnatiate enemyprefab
        // yield waitfor5seconds 


    }

    IEnumerator SpawnPowerRoutine()

    {

        while(stopSpawning == false)
        {

            Instantiate(tripleShotPowerUpPreFab, new Vector2(.42f, 6.85f), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 5f));


            Instantiate(speedPowerUpPreFab, new Vector2(.42f, 6.85f), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 5f));
        }

    }

    public void onPlayerDeath()

    {
        stopSpawning = true;

    }

    
}
