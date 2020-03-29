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
    void Start()
    {
        StartCoroutine(SpawnRoutine());
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

    public void onPlayerDeath()

    {
        stopSpawning = true;

    }

    
}
