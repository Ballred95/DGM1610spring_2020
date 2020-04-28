using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
 {

    
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score " + 0;   
    }

    public void UpdateScore(int playerScore)
    {
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
