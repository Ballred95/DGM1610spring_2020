﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPreFab;
    public int enemyIndex;
    public int numEnemies = 30;

    private void Awake()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {

       // for (int i = 0; i < numEnemies; i++)
       // {
            //Debug.Log("Creating enemy number: " + i);
           // Instantiate(enemyPreFab[1], new Vector3(5, 5, -5), enemyPreFab[1].transform.rotation);
        //}

    }

    // Update is called once per frame
    void Update()
    {

        //if(nanobot <= 100)
        //StartCoroutine("SpawnRoutine");

       // {
           // Instantiate(enemyPreFab[1], new Vector3(5, 5, -5), enemyPreFab[1].transform.rotation); }
        //NanoBots 
       
       


        if (Input.GetKeyDown(KeyCode.E))

        {
            Instantiate(enemyPreFab[enemyIndex], new Vector3(5, 5, -5), enemyPreFab[enemyIndex].transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        { Instantiate(enemyPreFab[1], new Vector3(5, 5, -5), enemyPreFab[1].transform.rotation); }
     

    }
    int a = 5;
    IEnumerable SpawnRoutine()

    { yield return null;

       
        
            while (a > 0)

            {
                
                Instantiate(enemyPreFab[1], new Vector3(5, 5, -5), enemyPreFab[1].transform.rotation);
            a--;
        }
        }
  
  }
