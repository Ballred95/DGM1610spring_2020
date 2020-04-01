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
    }

   

    // Update is called once per frame
    void Update()
    {
        if(currentDay == Days.mon)
        {
            print("Go back to bed!");

        }
    }
}
