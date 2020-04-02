using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{

    enum Days {sun = 1, mon};

    enum powerUp { speed, megaShot, health };

    powerUp currentPowerUp;

    Days currentDay;
    // Start is called before the first frame update
    void Start()
    {
        currentDay = Days.sun;
        currentPowerUp = powerUp.speed;
    }

   

    // Update is called once per frame
    void Update()
    {
        if(currentDay == Days.mon)
        {
            Debug.Log("Go back to bed!");

        }

        if(currentPowerUp == powerUp.speed)
        {

            Debug.Log("Collected speed powerup");
        }

        if(currentPowerUp == powerUp.megaShot)
        {
            Debug.Log("Collected megashot");

        }

        if(currentPowerUp == powerUp.health)
        {

            Debug.Log("Collected health");

        }
    }
}
