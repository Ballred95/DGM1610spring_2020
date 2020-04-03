using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{

    public string favHero;
    enum publidID { one, two, three };

    public string whichOne;
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
                Debug.Log("blah");
                break;


        }

        switch (whichOne)
        {

            case "publicID.one":
                print("dod");
                    break;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
