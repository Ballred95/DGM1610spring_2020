using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
  
{
    public float amount;
    public float money;
    public float cost;
    //Declaration
    public int cookieBox = 20;
   public float waterBottle;
   private string firstName;
   public double rbi;
   public string obiWan = "Hello there";
    public string madaphonil = "is cool";
    string answer = "The total is";
    public double total = 32.3;
    
  
    //type
    GameObject player;
    //Dclaration and initialization
    


    //Access modifier
    
    

    // Start is called before the first frame update
    
    void Start()
         
    {
        //function call
        Cookies(amount, money, cost);
        print(obiWan);
        
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void Cookies( float amount, float money, float cost)
    {
        float total;
        total= money - amount * cost;
        

    }

    

}
