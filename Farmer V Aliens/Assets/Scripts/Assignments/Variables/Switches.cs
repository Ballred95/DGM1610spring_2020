using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{

    public string favHero;
    enum PublicID { one, two, three };
    [SerializeField]
    PublicID myID;

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

        switch (myID)
        {

            case PublicID.one:
                print("one Switch");
                    break;

            case PublicID.two:
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
