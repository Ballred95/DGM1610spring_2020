using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score = 350;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("GameScore " + score);
        
    }

    public static void AddPoints(int pointsToAdd)
    {

        score += pointsToAdd;

    }
}
