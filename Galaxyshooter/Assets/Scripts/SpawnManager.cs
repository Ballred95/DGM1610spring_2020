using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPreFab;
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator SpawnRoutine()
    {
        //while loop
        while(true)
        {
            Instantiate(enemyPreFab, new Vector3(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
        
        //infinite loop
        //instnatiate enemyprefab
        // yield waitfor5seconds 


    }
}
