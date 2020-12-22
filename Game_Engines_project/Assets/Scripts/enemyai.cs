using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    public float Health = 1f;
    public GameObject player;
    public GameObject gun;
    public float shootingdistance;
    public NavMeshAgent agent;
    public GameObject barrel;
    public GameObject bullet;
    private float rateoffire;
    public float starttimebtwnshots;

    void Start()
    {
      
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        rateoffire = starttimebtwnshots;
    }

    // Update is called once per frame
    void Update()
    {
       
        agent.destination = player.transform.position;
        float target = Vector3.Distance(transform.position, player.transform.position);
        if (target < shootingdistance)
        {
           
            rateoffire -= Time.deltaTime;
            if (rateoffire <= 0)
            {
                shoot();
                Debug.Log("shoot");
            }
          
        }
        if (target > shootingdistance)
        {
            rateoffire = starttimebtwnshots;
        }

        if (Health <= 0)
        {
            die();

        }
    }
    void shoot()
    {
        Instantiate(bullet, barrel.transform.position, transform.rotation);
        rateoffire = starttimebtwnshots;
        Debug.Log("blah");
    }
    void die()
    {
        wavespawner.Enemiesalive--;
        Destroy(this.gameObject);
        Instantiate(gun.transform, transform.position, transform.rotation);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            character_script.health--;
        }
    
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootingdistance);

    }

}
