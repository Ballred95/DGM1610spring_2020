using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{

    public string favHero;
    enum publidID { one, two, three };

    public int whichOne;
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

            case 0:
                print("one Switch");
                    break;

            case 1:
                print("Two switch");
                break;

            default:
                print("Am I a joke to you?");
                break;

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SwitchStatement()
    {



    }
}
