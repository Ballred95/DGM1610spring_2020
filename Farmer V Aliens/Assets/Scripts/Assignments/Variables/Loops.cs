using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour

   
{

    public int numEnemies = 5;
    public int cupsInSink = 10;
    string[] strings = new string[3];

    
    // Start is called before the first frame update
    void Start()
    {

        strings[0] = "one";
        strings[1] = "two";
        strings[2] = "Three";

        for (int i = 0; i < numEnemies; i++) 
        {

            Debug.Log("Creating enemy number:" + i);

        }

        while(cupsInSink > 0)

        {

            Debug.Log("I've wshed a cup");
            cupsInSink--;

        }

        bool shouldContinue = false;
        do
        {

            print("Hi World");
        }
        while (shouldContinue == true);

        foreach(string item in strings)
        { print(item); }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
