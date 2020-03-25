using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{

    enum Days {sun = 1, mon};

    Days currentDay;
    // Start is called before the first frame update
    void Start()
    {
        currentDay = Days.sun;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
