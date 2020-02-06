using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
        
    }

    public static void AddPoints(int pointsToAdd)
    {

        score += pointsToAdd;
        Debug.Log("GameScore " + score);
    }
}
