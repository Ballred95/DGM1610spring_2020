using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour
{

    public int damage = 3;
    public int time = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            var hit = collision.gameObject;
            var health = hit.GetComponent<EnemyHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
                Debug.Log("ouch u hit me");

            }
                
                
                
                
                }
    }
    IEnumerator DestroyBullet()
    {

        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
