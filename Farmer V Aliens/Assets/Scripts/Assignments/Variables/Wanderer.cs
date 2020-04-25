using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Wanderer: MonoBehaviour
{

    public float wanderRadius;
    public float wanderTimer;

    public Transform target;
    private NavMeshAgent agent;
    private float timer;
    private Vector3 heading;


    //detection
    public float speed = 3;
    public float alertDist;
    public float attackDist;
    private float distance;

    //attack
    public int damage;


    // Use this for initialization
    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    private void Start()
    {
        distance = Vector3.Distance(target.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        //alert
        if(distance < alertDist && distance > attackDist)
        {
            print("enemy see target");
            speed += 2;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        //following
        else if(distance >= alertDist)
        {
            print("enemy follow");
            heading = target.position - transform.position;
            heading.y = 0;
            speed += 5;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if(heading.magnitude <= attackDist)
            {
                print("enemy attacking!");
                var health = target.gameObject.GetComponent<PlayerHealth>();
            }



        }

        //wandering
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}