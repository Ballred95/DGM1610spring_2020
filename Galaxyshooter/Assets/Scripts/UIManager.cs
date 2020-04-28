using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
 {

    
    public Text scoreText;
    public Text damageText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score " + 0;
        damageText.text = "Lives " + 3;
    }

    public void UpdateScore(int playerScore)
    {
        scoreText.text = "Score: " + playerScore.ToString();
    }

    public void UpdateDamage(int livesScore) {
        damageText.text = "Lives: " + livesScore.ToString();
    }
}
