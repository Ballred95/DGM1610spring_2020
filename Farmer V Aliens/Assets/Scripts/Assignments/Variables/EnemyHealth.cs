using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth;
    public Transform spawnPoint;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
    }

   public void TakeDamage(int amount) {
        currentHealth -= amount;


        if (currentHealth <= 0)
        {
            //Keep score at zero
            currentHealth = 0;
            print("Enemy is Dead!");

        }

        }
}
