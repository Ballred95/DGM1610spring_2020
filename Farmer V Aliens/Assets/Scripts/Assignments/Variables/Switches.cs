using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{

    public string favHero;
    // Start is called before the first frame update
    void Start()
    {
        if(favHero == "Superman")
        {
            print("Nerd Alert");

        }
       
        else if (favHero == "Thor")
        {
            print("Nice!");

        }

        switch (favHero)
        {
            case "Superman":
                print("NErd Alert");
                break;

            case "Thor":
                print("blah");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
